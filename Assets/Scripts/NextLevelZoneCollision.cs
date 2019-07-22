using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public StartPositionZoneCollision startzoneCol;
    public TherapyZoneCollision therapyZoneCol;
    public StartConfig startConfig;
    public GameObjectHandler objectHandler;
    bool isWaiting = false;

    public Text countDown;
    public GameObject countdown;
    private float time = 5f;
    private bool entered = false;

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
        StartCoroutine(Delay());
    }

    private void OnTriggerExit(Collider other)
    {
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
        if (isWaiting && entered)
        {
            startConfig.configRoom();
            objectHandler.showWayBack();
            Destroy(GameObject.FindWithTag("fearobject"));
            therapyZoneCol.levelIsRunning = false;
        }
    }
}