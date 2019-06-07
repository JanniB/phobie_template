using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectHandler: MonoBehaviour
{

    //Level Objects
   //GameObject startPositionMarker;
    GameObject crossMarker;
    GameObject terrarium;
    GameObject tutorialZone;

    private List<GameObject> fearObjectList = new List<GameObject>();
    public GameObject[] fearObjectsForList;
    public int currentFearObject = 0;

   

    // Use this for initialization
    void Start()
    {
        crossMarker = GameObject.FindWithTag("cross");
        //startPositionMarker = GameObject.FindWithTag("startposition");
        terrarium = GameObject.FindWithTag("terrarium");
        tutorialZone = GameObject.FindWithTag("tutorialzone");
        fearObjectsForList = GameObject.FindGameObjectsWithTag("fearobject");

        foreach (GameObject g in fearObjectsForList)
        {
            g.SetActive(false);
            fearObjectList.Add(g);
        }
        Debug.Log("Anzahl Angstobjekte: " + fearObjectList.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void resetRoom()
    {
        this.crossMarker.SetActive(false);
        //this.startPositionMarker.SetActive(false);
        this.terrarium.SetActive(false);
        this.hideAllFearObjects();
    }

    public void displayTutorialZone()
    {
        this.tutorialZone.SetActive(true);
    }

    void displayCrossMarker()
    {
        this.crossMarker.SetActive(true);
    }

    void displayStartPositionMarker()
    {
        //this.startPositionMarker.SetActive(true);
    }

    void displayTerrarium()
    {
        this.terrarium.SetActive(true);
    }


    /*
     * FearObjects
    */
    void hideAllFearObjects()
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
    }

    public int getFearObjectCount()
    {
        return fearObjectList.Count;
    }

    public void nextFearObject(int currentfo)
    {
        if (currentfo == fearObjectList.Count)
        {
            //TODO display endscreen
        }
        else
        {
            currentFearObject++;
            fearObjectList[currentFearObject].SetActive(true);
        }
        Debug.Log("current FearObject: " + currentFearObject);
    }

}
