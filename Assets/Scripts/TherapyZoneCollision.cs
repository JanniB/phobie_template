using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TherapyZoneCollision : MonoBehaviour
{
    //public GameObject fearObject;
    public GameObject cross;
    public TutorialZoneCollision tutorialZoneCollision;
    public LevelManager levelManager;
    public GameObject tutorialZone;
    public int aktuellerStep;

    // Start is called before the first frame update
    void Start()
    {
        //aktuellerStep = tutorialZoneCollision.startLevel;
        //fearObject = GameObject.FindWithTag("SpiderStep2"); //spezielles fearobjekt setzen je nach step
        levelManager.callNextLevel(levelManager.getLevel());

        cross = GameObject.FindWithTag("cross");
        tutorialZone = GameObject.FindWithTag("tutorialzone");
        //fearObject.SetActive(false);
        //hier fearlevel festlegen je nach Angsteinschätzung, aus tutorial holen


    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered Therapiezone");
        tutorialZone.SetActive(false);
        levelManager.callNextLevel(levelManager.getLevel());
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("entered Safety Area");
        //step muss einen zähler zurück gesetzt werden
       //clear all steps
    }

    //Buttons anvisieren, next level holen: public int nextStep; public NextLevelZoneCollision nextLevelZone = new NextLevelZoneCollision();

}

