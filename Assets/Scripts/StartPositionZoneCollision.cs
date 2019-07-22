using System.Collections;
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
        isWaiting = true;
        countdownFinished = false;

        objectHandler.therapyZone.SetActive(true);
        objectHandler.displayCrossMarker();
        StartCoroutine(Delay());
        objectHandler.hideCurvedArrow();
        objectHandler.hideWayBack();

        if(levelManager.getLevel() < 7)
        {
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
        if (isWaiting && entered)
        {
            if(levelManager.getLevel() == 0)
            {
                levelManager.setLevel(fearManager.calculateFearLevel());
                levelManager.callNextLevel(fearManager.calculateFearLevel());
            }
            else if (levelManager.getLevel() == 8)
            {
                var Instance = Instantiate(spiderPrefab, spawnPoint.position, spawnPoint.rotation);
                Instance.transform.parent = Spider8.transform;
                levelManager.callNextLevel(levelManager.getLevel());
            }
            else{
                levelManager.callNextLevel(levelManager.getLevel());
            }
            therapyZoneCol.levelIsRunning = true;
            objectHandler.crossMarker.SetActive(false);
        } 
    }
}