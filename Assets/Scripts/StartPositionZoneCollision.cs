using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartPositionZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public TherapyZoneCollision therapyZoneCol;
    public GameObjectHandler objectHandler;
    public FearManager fearManager;
    bool isWaiting = false;

    public GameObject spiderPrefab;
    public GameObject Spider8;
    public Transform spawnPoint;

    public Text countDown;
    public GameObject countdown;
    private float time = 5f;
    private bool entered = false;
    private bool countdownFinished = false;

    void Start()
    {
        countdown.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (entered)
        {
            countdown.SetActive(true);
            if (time > 1)
            {
                time -= Time.deltaTime;
                countDown.text = time.ToString("0");
            }
            else
            {
                countdown.SetActive(false);
            }
        }
    }


        void OnTriggerEnter(Collider other)
    {
        //entered = true;
        //Debug.Log("entered startzone + level: " + levelManager.getLevel());
        //timeout 3s
        isWaiting = true;
        countdownFinished = false;

        objectHandler.therapyZone.SetActive(true);
        objectHandler.displayCrossMarker();
        StartCoroutine(Delay());
        objectHandler.hideCurvedArrow();
        objectHandler.hideWayBack();

        if(levelManager.getLevel() < 7)
        {
            Debug.Log("LEvel > 7 display Terrarium");
            objectHandler.displayTerrarium();
        }else{
            objectHandler.fearobjectZone.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(!countdownFinished){
            objectHandler.crossMarker.SetActive(false);
            objectHandler.terrarium.SetActive(false);
            objectHandler.fearobjectZone.SetActive(false);
        }
        entered = false;
        time = 5f;
        countdown.SetActive(false);
        isWaiting = false;
        //Debug.Log("exit StartPositionZone");
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        entered = true;
        StartCoroutine(WaitCallNextLevel());

    }
    IEnumerator WaitCallNextLevel()
    {
        
        yield return new WaitForSeconds(5);
        countdownFinished = true;
        Debug.Log("5 seconds passed");
        if (isWaiting && entered)
        {
            if(levelManager.getLevel() == 0)
            {
                levelManager.setLevel(fearManager.calculateFearLevel());
                levelManager.callNextLevel(fearManager.calculateFearLevel());
                Debug.Log("TEEESCHDJ: " + levelManager.getLevel());
                objectHandler.setCurrentFearObject(levelManager.getLevel());
            }
            else if (levelManager.getLevel() == 8)
            {
                //Debug.Log("spinnen instanz");
                var Instance = Instantiate(spiderPrefab, spawnPoint.position, spawnPoint.rotation);
                Instance.transform.parent = Spider8.transform;
                levelManager.callNextLevel(levelManager.getLevel());
            }
            else{
                levelManager.callNextLevel(levelManager.getLevel()); //WURDE GEÄNDERT SPNST HIER RÜCKGÄNGG RAUS AUS ELSE
            }
            Debug.Log("lashdfl: " + levelManager.getLevel());
            therapyZoneCol.levelIsRunning = true;
            //Debug.Log("level is running" + therapyZoneCol.levelIsRunning);
            objectHandler.crossMarker.SetActive(false);
        } 
    }
}
