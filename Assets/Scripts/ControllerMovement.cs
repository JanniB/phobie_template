using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using System;

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
        Debug.Log("controller start: " + startPositionR);
    }

    void Update()
    {

    }
   

    public void calculateDistance()
    {
        distanceToPlayer = Math.Abs(InputTracking.GetLocalPosition(XRNode.RightHand).x - InputTracking.GetLocalPosition(XRNode.Head).x);
        Debug.Log("controller ende: " + (InputTracking.GetLocalPosition(XRNode.RightHand).x));//1.298956
        Debug.Log("person ende: " + (InputTracking.GetLocalPosition(XRNode.Head).x));//0.4703444
        setFearDistance(distanceToPlayer);
        Debug.Log("distance" + distanceToPlayer);
    }

    public float getFearDistance()
    {
        return distanceToPlayer = 10; //TODO = rausnehmen
    }

    public void setFearDistance(float distance)
    {
        distanceToPlayer = distance;
    }

}
