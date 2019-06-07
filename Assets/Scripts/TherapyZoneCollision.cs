using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TherapyZoneCollision : MonoBehaviour
{
    //public GameObject fearObject;
    public GameObject cross;
    //public TutorialZoneCollision tutorialZoneCollision;
    public LevelManager levelManager;
    public StartConfig startConfig;
    public StartPositionZoneCollision startzoneCol;
    public NextLevelZoneCollision nextlevelCol;
    //public GameObject tutorialZone;
    public int aktuellerStep;
    public bool levelIsRunning;

    // Start is called before the first frame update
    void Start()
    {
        //levelManager.callNextLevel(levelManager.getLevel());

        cross = GameObject.FindWithTag("cross");
        //tutorialZone = GameObject.FindWithTag("tutorialzone");
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
        if(levelIsRunning == true)
        {
            int levelrunning = levelManager.getLevel()-1;
            Debug.Log("level is running" + levelrunning);
            levelManager.callNextLevel(levelrunning);
        }
        else if (levelIsRunning == false)
        {
            startConfig.configRoom();
            levelManager.setLevel(levelManager.getLevel() + 1);
            Debug.Log("level is not running");

        }

    }

    private void OnTriggerExit(Collider other)
    {

        Debug.Log("entered Safety Area");
        startConfig.configRoom();

        //step muss einen zähler zurück gesetzt werden
        //clear all steps
    }

    //Buttons anvisieren, next level holen: public int nextStep; public NextLevelZoneCollision nextLevelZone = new NextLevelZoneCollision();

}

