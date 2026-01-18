// DO NOT TOUCH!

using System;
using UnityEngine;

public class SOARM101
{
    /// <summary>
    /// Forward Kinematics for SO Arm 101
    /// units: radians/cm
    /// use SOARM101() to initialize the class
    /// use arm.ForwardKinematics(angles) to get the end effector transformation matrix
    /// </summary>
    
    public float[] angles;
    public int[] rotationAxis; // z:2, x:0, y:1
    public Vector3[] linkOffsets;
    public Vector3 grabPositionOffset;

    public SOARM101()
    {
        angles = new float[] { 0, 0, 0, 0, 0, 0 };
        rotationAxis = new int[] { 2, 0, 0, 0, 1, 0 }; // z, x, x, x, y, x
        
        linkOffsets = new Vector3[]
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 31.15f, 119.7f),
            new Vector3(0, 112.35f, -28.0f),
            new Vector3(0, 134.9f, 4.85f),
            new Vector3(0, 54.8f, 0),
            new Vector3(0, 31.5f, 20.0f)
        };
        
        grabPositionOffset = new Vector3(0, 76.0f, -11.5f);
    }

    /// <summary>
    /// Generate Transformation matrix for each joint
    /// </summary>
    /// <param name="angle">angle of the joint, in radians</param>
    /// <param name="axis">axis of the joint, x:0, y:1, z:2</param>
    /// <param name="offset">offset of the joint, in cm</param>
    /// <returns>Transformation matrix</returns>
    public Matrix4x4 TransformationMatrix(float angle, int axis, Vector3 offset)
    {
        Matrix4x4 result = Matrix4x4.identity;
        
        float cos = Mathf.Cos(angle);
        float sin = Mathf.Sin(angle);
        
        switch (axis)
        {
            case 0: // X-axis rotation
                result.m00 = 1; result.m01 = 0; result.m02 = 0; result.m03 = offset.x;
                result.m10 = 0; result.m11 = cos; result.m12 = -sin; result.m13 = offset.y;
                result.m20 = 0; result.m21 = sin; result.m22 = cos; result.m23 = offset.z;
                result.m30 = 0; result.m31 = 0; result.m32 = 0; result.m33 = 1;
                break;
                
            case 1: // Y-axis rotation
                result.m00 = cos; result.m01 = 0; result.m02 = sin; result.m03 = offset.x;
                result.m10 = 0; result.m11 = 1; result.m12 = 0; result.m13 = offset.y;
                result.m20 = -sin; result.m21 = 0; result.m22 = cos; result.m23 = offset.z;
                result.m30 = 0; result.m31 = 0; result.m32 = 0; result.m33 = 1;
                break;
                
            case 2: // Z-axis rotation
                result.m00 = cos; result.m01 = -sin; result.m02 = 0; result.m03 = offset.x;
                result.m10 = sin; result.m11 = cos; result.m12 = 0; result.m13 = offset.y;
                result.m20 = 0; result.m21 = 0; result.m22 = 1; result.m23 = offset.z;
                result.m30 = 0; result.m31 = 0; result.m32 = 0; result.m33 = 1;
                break;
                
            default:
                Debug.LogError($"Invalid axis: {axis}");
                break;
        }
        
        return result;
    }

    /// <summary>
    /// Convert Euler angles to rotation matrix
    /// </summary>
    /// <param name="yaw">Yaw angle in radians (rotation around Z-axis)</param>
    /// <param name="pitch">Pitch angle in radians (rotation around Y-axis)</param>
    /// <param name="roll">Roll angle in radians (rotation around X-axis)</param>
    /// <returns>4x4 rotation matrix</returns>
    public Matrix4x4 EulerAnglesToRotationMatrix(float yaw, float pitch, float roll)
    {
        // Create rotation matrices for each axis
        Matrix4x4 rotX = Matrix4x4.identity;
        Matrix4x4 rotY = Matrix4x4.identity;
        Matrix4x4 rotZ = Matrix4x4.identity;
        
        // Roll (X-axis rotation)
        float cosRoll = Mathf.Cos(roll);
        float sinRoll = Mathf.Sin(roll);
        rotX.m11 = cosRoll; rotX.m12 = -sinRoll;
        rotX.m21 = sinRoll; rotX.m22 = cosRoll;
        
        // Pitch (Y-axis rotation)
        float cosPitch = Mathf.Cos(pitch);
        float sinPitch = Mathf.Sin(pitch);
        rotY.m00 = cosPitch; rotY.m02 = sinPitch;
        rotY.m20 = -sinPitch; rotY.m22 = cosPitch;
        
        // Yaw (Z-axis rotation)
        float cosYaw = Mathf.Cos(yaw);
        float sinYaw = Mathf.Sin(yaw);
        rotZ.m00 = cosYaw; rotZ.m01 = -sinYaw;
        rotZ.m10 = sinYaw; rotZ.m11 = cosYaw;
        
        // Combine rotations: R = Rz * Ry * Rx (ZYX convention)
        return rotZ * rotY * rotX;
    }
    /// <summary>
    /// Convert a 3x3 rotation matrix to a quaternion [x, y, z, w].
    /// </summary>
    /// <param name="R">Rotation matrix</param>
    /// <returns>Quaternion as Vector4 (x, y, z, w)</returns>
    public Vector4 RotationMatrixToQuaternion(Matrix4x4 R)
    {
        float trace = R.m00 + R.m11 + R.m22;
        float w, x, y, z;
        
        if (trace > 0)
        {
            float s = 2.0f * Mathf.Sqrt(trace + 1.0f);
            w = 0.25f * s;
            x = (R.m21 - R.m12) / s;
            y = (R.m02 - R.m20) / s;
            z = (R.m10 - R.m01) / s;
        }
        else
        {
            if ((R.m00 > R.m11) && (R.m00 > R.m22))
            {
                float s = 2.0f * Mathf.Sqrt(1.0f + R.m00 - R.m11 - R.m22);
                w = (R.m21 - R.m12) / s;
                x = 0.25f * s;
                y = (R.m01 + R.m10) / s;
                z = (R.m02 + R.m20) / s;
            }
            else if (R.m11 > R.m22)
            {
                float s = 2.0f * Mathf.Sqrt(1.0f + R.m11 - R.m00 - R.m22);
                w = (R.m02 - R.m20) / s;
                x = (R.m01 + R.m10) / s;
                y = 0.25f * s;
                z = (R.m12 + R.m21) / s;
            }
            else
            {
                float s = 2.0f * Mathf.Sqrt(1.0f + R.m22 - R.m00 - R.m11);
                w = (R.m10 - R.m01) / s;
                x = (R.m02 + R.m20) / s;
                y = (R.m12 + R.m21) / s;
                z = 0.25f * s;
            }
        }
        
        return new Vector4(x, y, z, w);
    }

    /// <summary>
    /// Forward Kinematics for SO Arm 101
    /// </summary>
    /// <param name="inputAngles">Joint angles (optional, uses current angles if null)</param>
    /// <returns>Array containing [quaternion, position] where quaternion is Vector4 and position is Vector3</returns>
    public object[] ForwardKinematics(float[] inputAngles = null)
    {
        float[] useAngles = inputAngles ?? angles;
        Matrix4x4 result = Matrix4x4.identity;
        
        for (int index = 0; index < useAngles.Length; index++)
        {
            result = result * TransformationMatrix(useAngles[index], rotationAxis[index], linkOffsets[index]);
        }
        
        result = result * TransformationMatrix(0, 0, grabPositionOffset);
        
        Vector4 quaternion = RotationMatrixToQuaternion(result);
        Vector3 position = new Vector3(result.m03, result.m13, result.m23);
        
        return new object[] { quaternion, position };
    }

    /// <summary>
    /// Quaternion conjugate
    /// </summary>
    /// <param name="q">Quaternion as Vector4 (x, y, z, w)</param>
    /// <returns>Conjugated quaternion</returns>
    private Vector4 QuatConj(Vector4 q)
    {
        return new Vector4(-q.x, -q.y, -q.z, q.w);
    }

    /// <summary>
    /// Quaternion multiplication
    /// </summary>
    /// <param name="q1">First quaternion</param>
    /// <param name="q2">Second quaternion</param>
    /// <returns>Product quaternion</returns>
    private Vector4 QuatMul(Vector4 q1, Vector4 q2)
    {
        float x1 = q1.x, y1 = q1.y, z1 = q1.z, w1 = q1.w;
        float x2 = q2.x, y2 = q2.y, z2 = q2.z, w2 = q2.w;
        
        float x = w1 * x2 + x1 * w2 + y1 * z2 - z1 * y2;
        float y = w1 * y2 - x1 * z2 + y1 * w2 + z1 * x2;
        float z = w1 * z2 + x1 * y2 - y1 * x2 + z1 * w2;
        float w = w1 * w2 - x1 * x2 - y1 * y2 - z1 * z2;
        
        return new Vector4(x, y, z, w);
    }

    /// <summary>
    /// Inverse Kinematics for SO Arm 101 (Numerical)
    /// </summary>
    /// <param name="quaternions">quaternions of the end effector (Vector4: x, y, z, w)</param>
    /// <param name="position">position of the end effector (Vector3)</param>
    /// <returns>Angles of the joints</returns>
    public float[] InverseKinematicsNumerical(Vector4 quaternions, Vector3 position)
    {
        // 1. Target pose
        Vector4 qTarget = quaternions;
        float normQ = Mathf.Sqrt(qTarget.x * qTarget.x + qTarget.y * qTarget.y + qTarget.z * qTarget.z + qTarget.w * qTarget.w);
        if (normQ > 0)
        {
            qTarget = qTarget / normQ;
        }

        Vector3 targetPos = position;

        // 3. Initial guess (numerical: default all zeros)
        float[] thetas = new float[6];

        // 4. Iteration parameters
        int maxIters = 300;
        float tol = 1e-4f;
        float step = 1e-3f;
        float damping = 1e-2f;

        // 5. Numerical IK main loop
        for (int iter = 0; iter < maxIters; iter++)
        {
            // Forward kinematics
            object[] fkResult = ForwardKinematics(thetas);
            Vector4 quatCur = (Vector4)fkResult[0];
            Vector3 posCur = (Vector3)fkResult[1];

            // Position error
            Vector3 posErr = targetPos - posCur;

            // Orientation error (using quaternion difference)
            Vector4 qErr = QuatMul(qTarget, QuatConj(quatCur));
            if (qErr.w < 0)
            {
                qErr = -qErr;
            }
            Vector3 oriErr = 2.0f * new Vector3(qErr.x, qErr.y, qErr.z);

            // Total error vector [6x1]
            float[] err = new float[6] { posErr.x, posErr.y, posErr.z, oriErr.x, oriErr.y, oriErr.z };
            float errNorm = 0;
            for (int i = 0; i < 6; i++)
            {
                errNorm += err[i] * err[i];
            }
            errNorm = Mathf.Sqrt(errNorm);

            // Convergence check
            if (errNorm < tol)
            {
                // Ensure joint angles are in range [-pi, pi]
                for (int i = 0; i < 6; i++)
                {
                    thetas[i] = ((thetas[i] + Mathf.PI) % (2 * Mathf.PI)) - Mathf.PI;
                }
                return thetas;
            }

            // Compute numerical Jacobian J (6x6)
            float[,] J = new float[6, 6];
            for (int j = 0; j < 6; j++)
            {
                float[] pert = (float[])thetas.Clone();
                pert[j] += step;

                object[] fkResultP = ForwardKinematics(pert);
                Vector4 quatP = (Vector4)fkResultP[0];
                Vector3 posP = (Vector3)fkResultP[1];

                Vector3 posErrP = targetPos - posP;
                Vector4 qErrP = QuatMul(qTarget, QuatConj(quatP));
                if (qErrP.w < 0)
                {
                    qErrP = -qErrP;
                }
                Vector3 oriErrP = 2.0f * new Vector3(qErrP.x, qErrP.y, qErrP.z);

                float[] errP = new float[6] { posErrP.x, posErrP.y, posErrP.z, oriErrP.x, oriErrP.y, oriErrP.z };
                
                for (int i = 0; i < 6; i++)
                {
                    J[i, j] = (errP[i] - err[i]) / step;
                }
            }

            // Damped least squares: Δθ = -(J^T J + λ²I)^(-1) J^T e
            float[,] JT = new float[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    JT[i, j] = J[j, i];
                }
            }

            float[,] H = new float[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    H[i, j] = 0;
                    for (int k = 0; k < 6; k++)
                    {
                        H[i, j] += JT[i, k] * J[k, j];
                    }
                    if (i == j) H[i, j] += damping * damping;
                }
            }

            float[] g = new float[6];
            for (int i = 0; i < 6; i++)
            {
                g[i] = 0;
                for (int k = 0; k < 6; k++)
                {
                    g[i] += JT[i, k] * err[k];
                }
            }

            // Solve H * dtheta = -g (simplified Gaussian elimination)
            float[] dtheta = SolveLinearSystem(H, g);
            for (int i = 0; i < 6; i++)
            {
                dtheta[i] = -dtheta[i];
            }

            // Limit maximum step size
            float maxStep = 0.2f;
            float scale = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Mathf.Abs(dtheta[i]) > scale)
                    scale = Mathf.Abs(dtheta[i]);
            }
            if (scale > maxStep)
            {
                for (int i = 0; i < 6; i++)
                {
                    dtheta[i] *= (maxStep / scale);
                }
            }

            // Backtracking line search (ensure error decreases)
            float alpha = 1.0f;
            bool updated = false;
            for (int backtrack = 0; backtrack < 5; backtrack++)
            {
                float[] candidate = new float[6];
                for (int i = 0; i < 6; i++)
                {
                    candidate[i] = thetas[i] + alpha * dtheta[i];
                }

                object[] fkResultC = ForwardKinematics(candidate);
                Vector4 quatC = (Vector4)fkResultC[0];
                Vector3 posC = (Vector3)fkResultC[1];

                Vector3 posErrC = targetPos - posC;
                Vector4 qErrC = QuatMul(qTarget, QuatConj(quatC));
                if (qErrC.w < 0)
                {
                    qErrC = -qErrC;
                }
                Vector3 oriErrC = 2.0f * new Vector3(qErrC.x, qErrC.y, qErrC.z);
                
                float[] errC = new float[6] { posErrC.x, posErrC.y, posErrC.z, oriErrC.x, oriErrC.y, oriErrC.z };
                float errCNorm = 0;
                for (int i = 0; i < 6; i++)
                {
                    errCNorm += errC[i] * errC[i];
                }
                errCNorm = Mathf.Sqrt(errCNorm);

                if (errCNorm < errNorm)
                {
                    thetas = candidate;
                    updated = true;
                    break;
                }

                alpha *= 0.5f;
            }

            if (!updated)
            {
                for (int i = 0; i < 6; i++)
                {
                    thetas[i] += dtheta[i];
                }
            }
        }

        // Ensure joint angles are in range [-pi, pi]
        for (int i = 0; i < 6; i++)
        {
            thetas[i] = ((thetas[i] + Mathf.PI) % (2 * Mathf.PI)) - Mathf.PI;
        }

        // Return current best after max iterations
        return thetas;
    }
    
    /// <summary>
    /// Solve linear system Ax = b using simplified Gaussian elimination
    /// </summary>
    /// <param name="A">6x6 matrix</param>
    /// <param name="b">6x1 vector</param>
    /// <returns>Solution vector x</returns>
    private float[] SolveLinearSystem(float[,] A, float[] b)
    {
        int n = 6;
        float[,] augmented = new float[n, n + 1];
        
        // Create augmented matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                augmented[i, j] = A[i, j];
            }
            augmented[i, n] = b[i];
        }
        
        // Forward elimination
        for (int i = 0; i < n; i++)
        {
            // Find pivot
            int maxRow = i;
            for (int k = i + 1; k < n; k++)
            {
                if (Mathf.Abs(augmented[k, i]) > Mathf.Abs(augmented[maxRow, i]))
                {
                    maxRow = k;
                }
            }
            
            // Swap rows
            for (int k = i; k < n + 1; k++)
            {
                float temp = augmented[maxRow, k];
                augmented[maxRow, k] = augmented[i, k];
                augmented[i, k] = temp;
            }
            
            // Make all rows below this one 0 in current column
            for (int k = i + 1; k < n; k++)
            {
                if (Mathf.Abs(augmented[i, i]) > 1e-10f)
                {
                    float c = augmented[k, i] / augmented[i, i];
                    for (int j = i; j < n + 1; j++)
                    {
                        if (i == j)
                        {
                            augmented[k, j] = 0;
                        }
                        else
                        {
                            augmented[k, j] -= c * augmented[i, j];
                        }
                    }
                }
            }
        }
        
        // Back substitution
        float[] solution = new float[n];
        for (int i = n - 1; i >= 0; i--)
        {
            solution[i] = augmented[i, n];
            for (int j = i + 1; j < n; j++)
            {
                solution[i] -= augmented[i, j] * solution[j];
            }
            if (Mathf.Abs(augmented[i, i]) > 1e-10f)
            {
                solution[i] /= augmented[i, i];
            }
        }
        
        return solution;
    }
}