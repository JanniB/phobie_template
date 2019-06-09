using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class ControllerMovement : MonoBehaviour
{
    Vector3 startPositionL;
    Vector3 startPositionR;
    //Vector3 endPositionL;
    Vector3 endPositionR;
    float distanceToPlayer;

    SteamVR_TrackedObject trackedObject;
    //Quaternion newRotation = Quaternion.identity;
    void Start() {
        startPositionL = InputTracking.GetLocalPosition(XRNode.LeftHand);
        startPositionR = InputTracking.GetLocalPosition(XRNode.RightHand);
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    void Update() {
       //endPositionL = new Vector3(InputTracking.GetLocalPosition(XRNode.LeftHand).x, 0, 0);
      
        endPositionR = new Vector3(InputTracking.GetLocalPosition(XRNode.RightHand).x, 0, 0);
        CalculateDistance(endPositionR);
    }
   

    void CalculateDistance(Vector3 endPos)
    {
        float hmdPosition = InputTracking.GetLocalPosition(XRNode.Head).x;

    }
}
