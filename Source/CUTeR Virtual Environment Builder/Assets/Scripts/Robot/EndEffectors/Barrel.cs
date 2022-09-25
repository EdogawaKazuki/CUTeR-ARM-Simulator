using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : EndEffector
{
    [SerializeField]
    Transform m_Barrel;
    [SerializeField]
    LineRenderer m_LineRenderer;
    private void Start()
    {
        //m_Barrel.SetParent(GameObject.Find("Robot").transform);
        Physics.gravity = new Vector3(0, -1000.0F, 0);
    }
    private void Update()
    {
        m_LineRenderer.SetPosition(0, transform.position);
        m_LineRenderer.SetPosition(1, m_Barrel.transform.position);
    }
    private void OnEnable()
    {
        m_Barrel.SetParent(GameObject.Find("Robot/RobotArm").transform);
        m_Barrel.gameObject.SetActive(true);
        GetComponent<ConfigurableJoint>().connectedBody = m_Barrel.GetComponent<Rigidbody>();
        GetComponent<ConfigurableJoint>().connectedAnchor = new Vector3(0,3,0);
    }
    private void OnDisable()
    {
        m_Barrel.gameObject.SetActive(false);
    }
    #region EndEffector Methods
    public override void Init()
    {
        base.Init();
        _name = "Barrel";
        _force = 0;
    }
    #endregion
}
