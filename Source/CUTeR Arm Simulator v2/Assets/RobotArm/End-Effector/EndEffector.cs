using UnityEngine;
public abstract class EndEffector : MonoBehaviour
{
    protected string _name;
    protected float _force;
    //protected RobotController _robotController;
    public virtual void Init()
    {
        _name = "Abstract EndEffector Class";
        _force = -1;
    }
    public GameObject GetGameObject() { return gameObject; }

    // get name
    public string GetEndEffectorName() { return _name; }
    // Change the state
    public virtual void Fire() { }

    public virtual void Reset() { }
    // (Optiuonal) Change the force 
    public void SetForce(float force) { _force = force; }

    // (Optional) Get the force
    public float GetForce() { return _force; }
    //public void SetRobotController(RobotController robotController) { _robotController = robotController; }

}