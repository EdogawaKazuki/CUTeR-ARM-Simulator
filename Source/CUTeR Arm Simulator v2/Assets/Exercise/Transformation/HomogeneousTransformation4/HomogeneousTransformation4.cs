using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HomogeneousTransformation4 : MonoBehaviour
{
    RobotController _robotController;
    TMP_Text[] matrix1Text;
    TMP_Text[] matrix2Text;
    TMP_Text[] matrix3Text;
    Matrix4x4 T_01;
    Matrix4x4 T_12;
    Matrix4x4 T_23;

    Transform baseTransform, joint1Transform, joint2Transform, joint3Transform;
    List<List<float>> _JointSetList = new List<List<float>> { new List<float> { -60, 60, -120 }};

    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        baseTransform = transform.Find("/Robot/Joints");
        joint1Transform = baseTransform.Find("Joint1");
        joint2Transform = joint1Transform.Find("Joint2");
        joint3Transform = joint2Transform.Find("Joint3");

        matrix1Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix2Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line3/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix3Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix3Text[i] = transform.Find("Input/Line4/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        transform.Find("Input/Line5/Set1").GetComponent<Button>().onClick.AddListener(() => SetJointAngles(new(){ -60, 60, -120 }));
    }
    private void FixedUpdate()
    {
        FindRelativeTransform();
        UpdateTable();
    }

    private Matrix4x4 transformLHtoRH(Matrix4x4 LH_transform)
    {
        // Create a conversion matrix to swap Y and Z
        Matrix4x4 LHtoRH = Matrix4x4.identity;
        LHtoRH[1, 1] = 0;
        LHtoRH[1, 2] = 1;
        LHtoRH[2, 1] = 1;
        LHtoRH[2, 2] = 0;
        
        // Apply conversion: RH = LHtoRH * T_01 * LHtoRH^-1
        Matrix4x4 LHtoRH_inv = LHtoRH.inverse;
        return LHtoRH * LH_transform * LHtoRH_inv;
    }
    private void FindRelativeTransform()
    {

        // Compute T_01 in left-handed system
        T_01 = baseTransform.worldToLocalMatrix * joint1Transform.localToWorldMatrix;
        T_01 = transformLHtoRH(T_01);

        T_12 = joint1Transform.worldToLocalMatrix * joint2Transform.localToWorldMatrix;
        T_12 = transformLHtoRH(T_12);

        T_23 = joint2Transform.worldToLocalMatrix * joint3Transform.localToWorldMatrix;
        T_23 = transformLHtoRH(T_23);
        
    }
    public void UpdateTable()
    {
        
        for (int i=0; i<16; i++)
        {
            matrix1Text[i].text = T_01[i/4, i%4].ToString("F2");
            matrix2Text[i].text = T_12[i/4, i%4].ToString("F2");
            matrix3Text[i].text = T_23[i/4, i%4].ToString("F2");
        }


    }

    public void SetJointAngles(List<float> joints)
    {
        _robotController.MoveJointsTo(joints);
    }
}
