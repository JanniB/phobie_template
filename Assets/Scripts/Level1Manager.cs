using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    public GameObject fearObject;
    public Vector3 startposition;
    public GameObject spiderStep3;
    public GameObject spiderStep2;

    //public GameObject nextLevelZone;
    //public int nextStep = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aufruf l1");

        //terrarium einblenden
        GameObject terrarium = GameObject.FindWithTag("terrarium");
        terrarium.SetActive(true);

        spiderStep3 = GameObject.FindWithTag("SpiderStep3");
        spiderStep3.SetActive(false);
        //nextLevelZone = GameObject.FindWithTag("nextLevelZone");
        //nextLevelZone.SetActive(true);

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
        Debug.Log("setStep1");
        setStartPosition();
        //clearSteps();
        fearObject = GameObject.FindWithTag("SpiderStep1");
        fearObject.SetActive(true);
    }

    public void setStep2()
    {
        Debug.Log("setStep2");
        setStartPosition();
        //clearSteps();
        fearObject = GameObject.FindWithTag("SpiderStep2");
        fearObject.SetActive(true);
    }

    public void setStep3()
    {
        Debug.Log("setStep3");
        setStartPosition();
        //clearSteps();
        //fearObject = GameObject.FindWithTag("SpiderStep3");
        spiderStep2 = GameObject.FindWithTag("SpiderStep2");
        spiderStep2.SetActive(false);
    }

    public void setStep4()
    {
        Debug.Log("setStep4");
        setStartPosition();
        //clearSteps();
        spiderStep3.SetActive(true);
        //fearObject = GameObject.FindWithTag("SpiderStep4");
        //fearObject.SetActive(true);
    }

    void clearSteps(){
        Debug.Log("clear steps");
        fearObject.SetActive(false);
    }
}
