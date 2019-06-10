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
    GameObject fear1;
    GameObject fear2;
    GameObject fear3;

    float subjectiveFear = 1f;
    float objectiveFear = 0f;
    float fearRes;

    // Use this for initialization
    void Start()
    {
        Debug.Log("test");
        fear1 = GameObject.FindWithTag("fearlevel1");
        fear2 = GameObject.FindWithTag("fearlevel2");
        fear3 = GameObject.FindWithTag("fearlevel3");
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

    public float getObjectiveFear()
    {
        return objectiveFear;
    }

    public void setObjectiveFear(float fear)
    {
        objectiveFear = fear;
    }

    public int calculateFearLevel()
    {
        Debug.Log("test calclevel");
        objectiveFear = controller.getFearDistance();
        fearRes = (subjectiveFear + objectiveFear)/2;
        fearRes = (float) Math.Round(fearRes, 0);
        Debug.Log("fear calculated in int: " + fearRes);
        return (int) fearRes;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");

        if (other.CompareTag("fearlevel1")) {
            setSubjectiveFear(1);
            Debug.Log("trigger fearlevel set to 1>1");
        }
        else if (other.CompareTag("fearlevel2")) {
            setSubjectiveFear(3);
            Debug.Log(" trigger fearlevel set to 2>3");
        }
        else if (other.CompareTag("fearlevel3"))
        {
            setSubjectiveFear(5);
            Debug.Log(" trigger fearlevel set to 3>5");
        }
    }

    private void OnTriggerExit(Collider other)
    {
       if(other.CompareTag("fearlevel1")|| other.CompareTag("fearlevel2") || other.CompareTag("fearlevel3"))
        {
            Debug.Log("trigger gate passed: " + getSubjectiveFear());
        }
        Destroy(gameObjectHandler.subjectiveFear);
        Debug.Log("trigger exit");

    }
}
