using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARController : MonoBehaviour
{
    [SerializeField] private GameObject _robot;
    [SerializeField] private GameObject _groundPlane;
    [SerializeField] private GameObject _mainCameraContainer;
    [SerializeField] private GameObject _arCameraContainer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetARMode(int value)
    {
        switch (value)
        {
            case 0: // No AR
                /*
                _imageTarget.gameObject.SetActive(false);
                _sceneManager.GetSceneContainer().SetParent(transform.parent);
                _sceneManager.GetSceneContainer().localPosition = Vector3.zero;
                _sceneManager.GetSceneContainer().localEulerAngles = Vector3.zero;
                _sceneManager.GetSceneContainer().localScale = Vector3.one;
                if (_sceneManager.GetPlayingScene())
                {
                    _sceneManager.GetPlayingScene().SetParent(transform.parent);
                    _sceneManager.GetPlayingScene().localPosition = Vector3.zero;
                    _sceneManager.GetPlayingScene().localEulerAngles = Vector3.zero;
                    _sceneManager.GetPlayingScene().localScale = Vector3.one;
                }
                _robotController.transform.SetParent(transform.parent);
                _robotController.transform.localEulerAngles = Vector3.zero;
                _robotController.transform.localPosition = Vector3.zero;
                _robotController.transform.localScale = new Vector3(100, 100, 100);
                _robotController.ShowJointLink(0);
                _robotController.ShowJointLink(1);
                _robotController.ShowJointLink(2);
                ShowRobot();
                ShowScene();
                */
                _robot.transform.position = new Vector3(0, 0, 0);
                _robot.transform.eulerAngles = new Vector3(0, 0, 0);
                GameObject.Find("VirtualScene").transform.position = new Vector3(0, -0.011f, 0.12f);
                GameObject.Find("VirtualScene").transform.eulerAngles = new Vector3(0, 0, 0);
                _robot.GetComponent<RobotController>().SetMask(false);
                _groundPlane.SetActive(true);
                _mainCameraContainer.gameObject.SetActive(true);
                _arCameraContainer.gameObject.SetActive(false);
                //_imageTarget.gameObject.SetActive(false);
                break;
            case 1: // Full AR
                /*
                _imageTarget.gameObject.SetActive(true);
                _robotController.transform.SetParent(_imageTarget);
                _robotController.transform.localEulerAngles = new Vector3(0, 180, 0);
                _robotController.transform.localPosition = new Vector3(0, -4.301f, 11.9f);
                _robotController.transform.localScale = new Vector3(100, 100, 100);
                _sceneManager.GetSceneContainer().SetParent(_imageTarget);
                _sceneManager.GetSceneContainer().localPosition = _robotController.transform.localPosition;
                _sceneManager.GetSceneContainer().localEulerAngles = _robotController.transform.localEulerAngles;
                _sceneManager.GetSceneContainer().localScale = _robotController.transform.localScale * 0.01f;
                if (_sceneManager.GetPlayingScene())
                {
                    _sceneManager.GetPlayingScene().SetParent(_imageTarget);
                    _sceneManager.GetPlayingScene().localPosition = _robotController.transform.localPosition;
                    _sceneManager.GetPlayingScene().localEulerAngles = Vector3.zero;
                    _sceneManager.GetSceneContainer().localScale = _robotController.transform.localScale * 0.01f;
                }
                
                */
                _robot.transform.position = new Vector3(0, -0.05f, 0.12f);
                _robot.transform.eulerAngles = new Vector3(0, 180, 0);
                GameObject.Find("VirtualScene").transform.position = new Vector3(0, -0.05f-0.011f, 0.12f);
                GameObject.Find("VirtualScene").transform.eulerAngles = new Vector3(0, 180, 0);
                _robot.GetComponent<RobotController>().SetMask(true);
                _groundPlane.SetActive(false);
                _mainCameraContainer.gameObject.SetActive(false);
                _arCameraContainer.gameObject.SetActive(true);
                //_imageTarget.gameObject.SetActive(true);
                break;
            case 2: // AR with Robot Layer
                /*
                _imageTarget.gameObject.SetActive(true);
                _robotController.transform.SetParent(_imageTarget);
                _robotController.transform.localEulerAngles = new Vector3(0, 180, 0);
                _robotController.transform.localPosition = new Vector3(0, -4.301f, 11.9f);
                _robotController.transform.localScale = new Vector3(100, 100, 100);
                _sceneManager.GetSceneContainer().SetParent(_imageTarget);
                _sceneManager.GetSceneContainer().localPosition = _robotController.transform.localPosition;
                _sceneManager.GetSceneContainer().localEulerAngles = _robotController.transform.localEulerAngles;
                _sceneManager.GetSceneContainer().localScale = _robotController.transform.localScale * 0.01f;
                if (_sceneManager.GetPlayingScene())
                {
                    _sceneManager.GetPlayingScene().SetParent(_imageTarget);
                    _sceneManager.GetPlayingScene().localPosition = _robotController.transform.localPosition;
                    _sceneManager.GetPlayingScene().localEulerAngles = Vector3.zero;
                    _sceneManager.GetSceneContainer().localScale = _robotController.transform.localScale * 0.01f;
                }
                
                */
                _robot.transform.position = new Vector3(0, -0.05f, 0.12f);
                _robot.transform.eulerAngles = new Vector3(0, 180, 0);
                // _robot.GetComponent<RobotController>().SetMask(true);
                _groundPlane.SetActive(false);
                _mainCameraContainer.gameObject.SetActive(false);
                _arCameraContainer.gameObject.SetActive(true);
                //_imageTarget.gameObject.SetActive(true);
                break;
        }
    }
}
