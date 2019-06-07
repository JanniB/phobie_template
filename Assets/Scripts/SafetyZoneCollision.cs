using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyZoneCollision : MonoBehaviour
{
    //public GameObject fearObject;
    public GameObject cross;
    public TutorialZoneCollision tutorialZoneCollision;
    public NextLevelZoneCollision nextLevelZoneCollision;
    public int aktuellerStep;

    // Start is called before the first frame update
    void Start()
    {
        //aktuellerStep = tutorialZoneCollision.startLevel;
        //fearObject = GameObject.FindWithTag("SpiderStep2"); //spezielles fearobjekt setzen je nach step

        cross = GameObject.FindWithTag("cross");
        //fearObject.SetActive(false);
        //hier fearlevel festlegen je nach Angsteinschätzung, aus tutorial holen


    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        //nextLevelZoneCollision.setStep();
        Debug.Log("entered Therapiezone");
        //fearObject.SetActive(true);
        cross.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("entered Safety Area");
        //step muss einen zähler zurück gesetzt werden
        //fearObject.SetActive(false);
        cross.SetActive(true);

       //clear all steps
    }

    //Buttons anvisieren, next level holen: public int nextStep; public NextLevelZoneCollision nextLevelZone = new NextLevelZoneCollision();

}

