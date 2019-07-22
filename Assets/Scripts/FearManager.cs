using UnityEngine;
using System.Collections;
using Valve.VR;
using UnityEngine.XR;
using System;

public class FearManager : MonoBehaviour
{

    //public LevelManager levelManager;
    public GameObjectHandler gameObjectHandler;
    public ControllerMovement controller;
    int startLevel;
    float subjectiveFear = 1f;
    float fearRes;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getSubjectiveFear()
    {
        return subjectiveFear;
    }

    public void setSubjectiveFear(float fear)
    {
        subjectiveFear = fear;
    }

    public int calculateFearLevel()
    {
        fearRes = (controller.getFearDistance() + getSubjectiveFear()) / 2;
        Debug.Log("FEARLEVEL: " + fearRes);
        if (fearRes < 2.3)
        {
            startLevel = 1;
        }
        else if (fearRes < 3.8)
        {
            startLevel = 3;
        }
        else
        {
            startLevel = 5;
        }
        Debug.Log("startlevel: " + startLevel);
        return startLevel;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fearlevel1")) {
            setSubjectiveFear(1);
        }
        else if (other.CompareTag("fearlevel2")) {
            setSubjectiveFear(2);
        }
        else if (other.CompareTag("fearlevel3"))
        {
            setSubjectiveFear(3);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObjectHandler.subjectiveFear);
    }
}
