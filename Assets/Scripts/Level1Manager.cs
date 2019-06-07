using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    //public GameObject fearObject;
    public Vector3 startposition;

    //Spider objects
    public GameObject spiderStep1;
    public GameObject spiderStep2;
    public GameObject spiderStep3;
    public GameObject spiderStep4;


    //public GameObject nextLevelZone;
    //public int nextStep = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aufruf l1");

        //show terrarium
        GameObject terrarium = GameObject.FindWithTag("terrarium");
        terrarium.SetActive(true);

        //hide all spider objects
        spiderStep1 = GameObject.FindWithTag("SpiderStep1");
        spiderStep1.SetActive(false);
        spiderStep2 = GameObject.FindWithTag("SpiderStep2");
        spiderStep2.SetActive(false);
        spiderStep3 = GameObject.FindWithTag("SpiderStep3");
        spiderStep3.SetActive(false);
        spiderStep4 = GameObject.FindWithTag("SpiderStep4");
        spiderStep4.SetActive(false);


        //nextLevelZone = GameObject.FindWithTag("nextLevelZone");
        //nextLevelZone.SetActive(true);

        //set startposition
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
        Debug.Log("setStep1");
        setStartPosition();
        clearSteps();
        spiderStep1.SetActive(true);
    }

    public void setStep2()
    {
        Debug.Log("setStep2");
        setStartPosition();
        clearSteps();
        spiderStep2.SetActive(true);
    }

    public void setStep3()
    {
        Debug.Log("setStep3");
        setStartPosition();
        clearSteps();
        spiderStep3.SetActive(true);
    }

    public void setStep4()
    {
        Debug.Log("setStep4");
        setStartPosition();
        clearSteps();
        spiderStep4.SetActive(true);
    }

    void clearSteps(){
        Debug.Log("clear steps");
        spiderStep1.SetActive(false);
        spiderStep2.SetActive(false);
        spiderStep3.SetActive(false);
        spiderStep4.SetActive(false);
    }
}
