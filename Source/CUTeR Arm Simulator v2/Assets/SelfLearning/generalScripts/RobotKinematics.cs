using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

// using System.Windows.Forms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using Matrix4x4 = UnityEngine.Matrix4x4;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

public class RobotKinematics : MonoBehaviour
{
    // DH parameters for OpenManipulator-P (in meters)
    private  float[,] dhParams = new float[6, 4];

    public float[] theta_sign = new float[]
    {
        1f, -1f, -1f, 1f, -1f, -1f
    };

    public Matrix4x4 T_debug;
    void Start()
    {
        Debug.Log("Initializing Robot Kinematics DH Parameters.");
        if (true)
        {
            dhParams = new float[,]
            {
                // a,         alpha,           d,         thetaOffset
                { 0.000f,     Mathf.PI/2,     0.159f,    Mathf.PI/2 },                                  // Link 2
                { Mathf.Sqrt(0.264f * 0.264f + 0.03f * 0.03f), 0f, 0f, Mathf.PI/2 - Mathf.Atan2(0.03f, 0.264f) }, // Link 3
                { 0.03f,      Mathf.PI/2,     0f,        Mathf.PI/4 + Mathf.Atan2(0.03f, 0.264f) },     // Link 4
                { 0f,        -Mathf.PI/2,     0.258f,    0f },                                          // Link 5
                { 0f,         Mathf.PI/2,     0f,        0f },                                          // Link 6
                { 0f,         Mathf.PI/2,             0.123f,    Mathf.PI/2 }                                           // End-Effector
            };
        }
    }
    // Homogeneous transformation for one DH link
    private static Matrix4x4 DHTransform(float a, float alpha, float d, float theta)
    {
        float ct = Mathf.Cos(theta);
        float st = Mathf.Sin(theta);
        float ca = Mathf.Cos(alpha);
        float sa = Mathf.Sin(alpha);

        Matrix4x4 T = new Matrix4x4();

        T[0, 0] = ct;           T[0, 1] = -st * ca;     T[0, 2] = st * sa;     T[0, 3] = a * ct;
        T[1, 0] = st;           T[1, 1] = ct * ca;      T[1, 2] = -ct * sa;    T[1, 3] = a * st;
        T[2, 0] = 0f;           T[2, 1] = sa;           T[2, 2] = ca;          T[2, 3] = d;
        T[3, 0] = 0f;           T[3, 1] = 0f;           T[3, 2] = 0f;          T[3, 3] = 1f;

        return T;
    }

    private float[] Sim2Model(float[] q)
    {
        float[] modelQ = new float[q.Length];
        for (int i = 0; i < q.Length; i++)
        {
            modelQ[i] = theta_sign[i] * q[i] * Mathf.Deg2Rad;
        }
        return modelQ;
    }

    public static Vector3 GetEulerAnglesXYZ(Matrix4x4 rotationMatrix)
    {
        float r20 = rotationMatrix[2, 0];
        float r21 = rotationMatrix[2, 1];
        float r22 = rotationMatrix[2, 2];
        float r10 = rotationMatrix[1, 0];
        float r00 = rotationMatrix[0, 0];

        float pitch; // Y rotation

        // Normal case
        if (Mathf.Abs(r20) < 1f - Mathf.Epsilon)
        {
            pitch = -Mathf.Asin(r20);
            float roll = Mathf.Atan2(r21, r22);                    // X
            float yaw   = Mathf.Atan2(r10, r00);                    // Z
            return new Vector3(roll * Mathf.Rad2Deg, pitch * Mathf.Rad2Deg, yaw * Mathf.Rad2Deg);
        }
        else
        {
            // Gimbal lock case
            pitch = -Mathf.Sign(r20) * Mathf.PI / 2f; // ±90 degrees

            // We can arbitrarily set one angle to 0; convention: roll = 0
            float roll = 0f;
            float yaw = Mathf.Atan2(-rotationMatrix[0,1], rotationMatrix[1,1]);

            return new Vector3(roll * Mathf.Rad2Deg, pitch * Mathf.Rad2Deg, yaw * Mathf.Rad2Deg);
        }
    }
    public float[] ComputeForwardKinematics(float[] q)
    {
        // convert angle to rad
        q = Sim2Model(q);
        if (q.Length != 6)
            throw new System.ArgumentException("Exactly 6 joint angles required.");

        var T = Matrix4x4.identity;

        // Forward kinematics
        for (int i = 0; i < 6; i++)
        {
            float theta = q[i] + dhParams[i, 3];
            Matrix4x4 Ai = DHTransform(dhParams[i, 0], dhParams[i, 1], dhParams[i, 2], theta);
            T = T * Ai;
            if (i == 5)
                T_debug = T;
        }

        Vector3 position = T.GetColumn(3);
        // Extract Euler angles (ZYX convention)
        // float roll = Mathf.Atan2(T[2, 1], T[2, 2]);
        // float pitch = Mathf.Asin(-T[2, 0]);
        // float yaw = Mathf.Atan2(T[1, 0], T[0, 0]);
        Vector3 eulerAngles = GetEulerAnglesXYZ(T);
        float roll = eulerAngles.x;
        float pitch = eulerAngles.y;
        float yaw = eulerAngles.z;
        return new float[]
        {
            position.x * 100f, position.y * 100f, position.z * 100f,
            roll, pitch, yaw
        };
    }
    /// <summary>
    /// Computes the 6x6 geometric Jacobian for the OpenManipulator-P.
    /// </summary>
    /// <param name="q">Array of 6 joint angles in radians (q1 to q6)</param>
    /// <returns>6x6 Jacobian matrix (rows: vx,vy,vz,wx,wy,wz; columns: joints 1-6)</returns>
    public float[,] ComputeJacobian(float[] q)
    {
        // convert angle to rad
        q = Sim2Model(q);
        if (q.Length != 6)
            throw new System.ArgumentException("Exactly 6 joint angles required.");

        Vector3[] positions = new Vector3[7]; // p0 (base) to p6 (EE)
        Vector3[] zAxes = new Vector3[7];     // rotation axis of each joint in world frame

        Matrix4x4 T = Matrix4x4.identity;
        positions[0] = Vector3.zero;
        zAxes[0] = new Vector3(0f, 0f, 1f); // z0 axis
        // Forward kinematics to get positions and z-axes
        for (int i = 0; i < 6; i++)
        {
            float theta = q[i] + dhParams[i, 3];
            Matrix4x4 Ai = DHTransform(dhParams[i, 0], dhParams[i, 1], dhParams[i, 2], theta);
            T = T * Ai;

            positions[i + 1] = T.GetColumn(3);           // position of frame i+1
            zAxes[i+1] = T.GetColumn(2);                  // z-axis of frame i (joint i axis)
            Debug.Log($"Joint {i+1} position: {positions[i + 1]}, z-axis: {zAxes[i+1]}");
        }

        Vector3 pe = positions[6]; // end-effector position

        // Build Jacobian (6 rows × 6 columns)
        // 6x6 Jacobian matrix
        float[,] J = new float[6, 6];

        for (int i = 0; i < 6; i++)
        {
            Vector3 jp = Vector3.Cross(zAxes[i], (pe - positions[i]));  // linear part
            Vector3 jw = zAxes[i];                                     // angular part

            J[0, i] = jp.x;
            J[1, i] = jp.y;
            J[2, i] = jp.z;
            J[3, i] = jw.x;
            J[4, i] = jw.y;
            J[5, i] = jw.z;
        }

        return J;
    }

    // Example usage in Unity (uncomment to test in Update)
    /*
    void Update()
    {
        float[] joints = new float[] { 0f, 0f, 0f, 0f, 0f, 0f }; // home position
        Matrix4x4 J = ComputeJacobian(joints);
        Debug.Log("Jacobian at home:\n" + J.ToString());
    }
    */
}