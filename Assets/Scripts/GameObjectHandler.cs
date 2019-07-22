using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectHandler: MonoBehaviour
{
    public GameObject nextLevelZone;
    public GameObject crossMarker;
    public GameObject startPositionZone;
    public GameObject terrarium;
    public GameObject tutorialZone;
    public GameObject subjectiveFear;
    public GameObject objectiveFear;
    public GameObject therapyZone;
    public GameObject fearobjectZone;
    public GameObject curvedArrow;
    public GameObject curvedArrowNextLevel;
    public GameObject uturnArrow;

    public List<GameObject> fearObjectList = new List<GameObject>();
    public List<GameObject> objectiveFearList = new List<GameObject>();

    public GameObject[] fearObjects;
    public GameObject[] objectiveFearObjects;
    public int currentFearObject = 0;


    // Use this for initialization
    void Start()
    {
        fearObjects = GameObject.FindGameObjectsWithTag("fearobject");
        foreach (GameObject g in fearObjects)
        {
            fearObjectList.Add(g);
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
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
    public void hideCurvedArrow(){
        this.curvedArrow.SetActive(false);
    }
    public void showCurvedArrow(){
        this.curvedArrow.SetActive(true);
    }
    public void hideWayBack(){
        this.uturnArrow.SetActive(false);
        this.curvedArrowNextLevel.SetActive(false);
    }
    public void showWayBack()
    {
        this.uturnArrow.SetActive(true);
        this.curvedArrowNextLevel.SetActive(true);
    }

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
            //therapie beendet
        } 
            fearObjects[0].SetActive(true);
            fearObjects[currentFearObject].SetActive(true);
    }

    public int getFearObjectCount()
    {
        return fearObjectList.Count;
    }
}