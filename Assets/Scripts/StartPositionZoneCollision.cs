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
    private float time = 6f;
    private bool entered = false;

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
        entered = true;
        Debug.Log("entered startzone + level: " + levelManager.getLevel());
        //timeout 3s
        isWaiting = true;
        objectHandler.therapyZone.SetActive(true);
        objectHandler.displayCrossMarker();
        StartCoroutine(WaitCallNextLevel());

        if(levelManager.getLevel() < 7)
        {
            Debug.Log("LEvel > 7 display Terrarium");
            objectHandler.displayTerrarium();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        entered = false;
        time = 6f;
        isWaiting = false;
        Debug.Log("exit StartPositionZone");
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
    }

    IEnumerator WaitCallNextLevel()
    {
        
        yield return new WaitForSeconds(5);
        Debug.Log("5 seconds passed");
        if (isWaiting)
        {
            if(levelManager.getLevel() == 0)
            {
                levelManager.setLevel(fearManager.calculateFearLevel());
                
            }
            else if (levelManager.getLevel() == 8)
            {
                Debug.Log("spinnen instanz");
                var Instance = Instantiate(spiderPrefab, spawnPoint.position, spawnPoint.rotation);
                Instance.transform.parent = Spider8.transform;
            }
            levelManager.callNextLevel(levelManager.getLevel());
            therapyZoneCol.levelIsRunning = true;
            Debug.Log("level is running" + therapyZoneCol.levelIsRunning);
            objectHandler.crossMarker.SetActive(false);
        }
    }
}
