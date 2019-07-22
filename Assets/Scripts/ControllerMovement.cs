using System.Collections;
using UnityEngine;
using Valve.VR;
using UnityEngine.XR;
using System;

public class ControllerMovement : MonoBehaviour
{
    float distanceToPlayer;
    float playerPosition;
    float fearObjectPosition;
    GameObject startTutorial;
    public objectiveFearZone objectiveFearZone;

    void Start() {
        startTutorial = GameObject.FindWithTag("startTutorialMarker");
    }

    void Update()
    {

    }

    public void calculateDistance()
    {
        fearObjectPosition = objectiveFearZone.getFearDistancePos();
        playerPosition = Mathf.Abs(startTutorial.transform.position.x);
        distanceToPlayer = fearObjectPosition - playerPosition;
        setFearDistance(distanceToPlayer);
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