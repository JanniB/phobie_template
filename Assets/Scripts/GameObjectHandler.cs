using UnityEngine;
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
 

    public List<GameObject> fearObjectList = new List<GameObject>();
    public GameObject[] fearObjects;
    public int currentFearObject = 0;

    public GameObject subjectiveFear;


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

        foreach (GameObject g in fearObjects)
        {
            fearObjectList.Add(g);
            Debug.Log("Anzahl Angstobjekte: " + fearObjectList.Count);
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

    public void setCurrentFearObject(int level)
    {
        currentFearObject = level;
        if (currentFearObject == fearObjectList.Count)
        {
            Debug.Log("Congratulations, you finished therapy!");
        }
        else
        {
            fearObjects[0].SetActive(true);
            fearObjects[currentFearObject].SetActive(true);
            Debug.Log("current fear Object set to: " + currentFearObject);
        }
    }

    public int getFearObjectCount()
    {
        return fearObjectList.Count;
    }

}
