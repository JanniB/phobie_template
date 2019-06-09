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
    float endPositionR;
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
      
        endPositionR = InputTracking.GetLocalPosition(XRNode.RightHand).x;
        CalculateDistance(endPositionR);
    }
   

    void CalculateDistance(float endPos)
    {
        float hmdPosition = InputTracking.GetLocalPosition(XRNode.Head).x;
        setFearDistance(endPos - hmdPosition);
        //Debug.Log("distance" + distanceToPlayer);
    }

    public float getFearDistance()
    {
        return distanceToPlayer;
    }

    public void setFearDistance(float distance)
    {
        distanceToPlayer = distance;
    }

}
