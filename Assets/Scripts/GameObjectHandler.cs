﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectHandler: MonoBehaviour
{

    //Level Objects
    public GameObject nextLevelZone;
    public GameObject crossMarker;
    public GameObject startPositionZone;
    public GameObject terrarium;
    public GameObject tutorialZone;
    public GameObject subjectiveFear;
    public GameObject objectiveFear;
    public GameObject therapyZone;
    public GameObject fearobjectZone;

    public List<GameObject> fearObjectList = new List<GameObject>();
    public List<GameObject> objectiveFearList = new List<GameObject>();

    public GameObject[] fearObjects;
    public GameObject[] objectiveFearObjects;
    public int currentFearObject = 0;


    // Use this for initialization
    void Start()
    {
        //crossMarker = GameObject.FindWithTag("cross");
        //nextLevelZone = GameObject.FindWithTag("nextLevelZone");
        //startPositionZone = GameObject.FindWithTag("startPositionZone");
        //terrarium = GameObject.FindWithTag("terrarium");
        //tutorialZone = GameObject.FindWithTag("tutorialzone");
        fearObjects = GameObject.FindGameObjectsWithTag("fearobject");
        //subjectiveFear = GameObject.FindGameObjectWithTag("fearGates");
        //objectiveFear = GameObject.FindGameObjectWithTag("fearDistance");


        foreach (GameObject g in fearObjects)
        {
            fearObjectList.Add(g);
            g.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("current fear obejct: " + currentFearObject);
    }


    public void resetRoom()
    {
        this.crossMarker.SetActive(false);
        this.nextLevelZone.SetActive(false);
        this.terrarium.SetActive(false);
        this.fearobjectZone.SetActive(false);
        hideAllFearObjects();
    }

    public void displayTutorialZone()
    {
        this.tutorialZone.SetActive(true);
    }

    public void displayCrossMarker()
    {
        this.crossMarker.SetActive(true);
    }

    public void displayStartPositionZone()
    {
        this.startPositionZone.SetActive(true);
    }

    public void displayNextLevelZone()
    {
        this.nextLevelZone.SetActive(true);
    }

    public void displayTerrarium()
    {
        this.terrarium.SetActive(true);
    }

    public void displaySubjectiveFear()
    {
        this.subjectiveFear.SetActive(true);
    }
    public void displayFearobjectZone(){
        this.fearobjectZone.SetActive(true);
    }



    /*
     * FearObjects
    */
    public void hideAllFearObjects()
    {
        foreach (GameObject g in fearObjectList)
        {
            g.SetActive(false);
        }
    }

    public List<GameObject> getFearObjects()
    {
        return fearObjectList;
    }

    public GameObject getCurrentFearObject()
    {
        return fearObjectList[currentFearObject];
    }

    public int getCurrentFearObjectNr()
    {
        return currentFearObject;
    }

    public void setCurrentFearObject(int level)
    {
        currentFearObject = level;
        if (currentFearObject == fearObjectList.Count)
        {

            Debug.Log("Congratulations, you finished therapy!");
            //therapie beendet
        } 
            fearObjects[0].SetActive(true);
            fearObjects[currentFearObject].SetActive(true);
            Debug.Log("current fear Object set to: " + currentFearObject);
    }

    public int getFearObjectCount()
    {
        return fearObjectList.Count;
    }

}
