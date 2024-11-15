using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEffectorController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private List<EndEffector> _endEffectors = new List<EndEffector>();
    [SerializeField]
    private RobotController _robotController;

    private int _currentEndEffectorIndex;
    private EndEffector _currentEndEffector;
    private List<string> _endEffectorNames = new List<string>();
    #endregion
    #region MonoBehaviour
    private void Start()
    {

        for(int i = 0; i < _endEffectors.Count; i++)
        {
            _endEffectors[i].Init();
            _endEffectorNames.Add(_endEffectors[i].GetEndEffectorName());
            _endEffectors[i].SetRobotController(_robotController);
            //Debug.Log(_endEffectorNames[i]);
        }
        SetEndEffector(0);
    }
    #endregion
    #region Methods
    public void SetEndEffector(int index)
    {
        for(int i = 0; i < _endEffectors.Count; i++)
        {
            _endEffectors[i].GetGameObject().SetActive(false);
        }
        _currentEndEffector = _endEffectors[index];
        _currentEndEffector.GetGameObject().SetActive(true);
        _currentEndEffectorIndex = index;
    }
    public int GetEndEffector() { return _currentEndEffectorIndex; }
    public void Fire()
    {
        if (_robotController.GetEditorController().GetSceneManager().GetPlayingScene() != null){
            _currentEndEffector?.Fire();
            Debug.Log("Fire" + _currentEndEffector.GetEndEffectorName());
        }
    }
    public void SetForce(float force)
    {
        _currentEndEffector?.SetForce(force);
    }
    public List<string> GetEndEffectorList()
    {
        return _endEffectorNames;
    }

    public void ResetEndEffector()
    {
        _currentEndEffector.Reset();
    }
    #endregion
}
