﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    public GameObject fearObject;
    public Vector3 startposition;
    public GameObject nextLevelZone;
    public int nextStep = 1;


    // Start is called before the first frame update
    void Start()
    {
        //terrarium einblenden
        GameObject terrarium = GameObject.FindWithTag("terrarium");
        terrarium.SetActive(true);

        nextLevelZone = GameObject.FindWithTag("nextLevelZone");
        nextLevelZone.SetActive(true);

        // startposition zuweisen
        setStartPosition();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void setStartPosition() {
        //TODO
    }

    public void setStep1(){
        setStartPosition();
        clearSteps();
        fearObject = GameObject.FindWithTag("SpiderStep1");
        fearObject.SetActive(true);
    }

    public void setStep2()
    {
        setStartPosition();
        clearSteps();
        fearObject = GameObject.FindWithTag("SpiderStep2");
        fearObject.SetActive(true);
    }

    public void setStep3()
    {
        setStartPosition();
        clearSteps();
        fearObject = GameObject.FindWithTag("SpiderStep3");
        fearObject.SetActive(true);
    }

    public void setStep4()
    {
        setStartPosition();
        clearSteps();
        fearObject = GameObject.FindWithTag("SpiderStep4");
        fearObject.SetActive(true);
    }

    void clearSteps(){
        fearObject.SetActive(false);
    }
}
