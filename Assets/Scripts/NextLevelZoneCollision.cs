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
        //5s
        isWaiting = true;
        StartCoroutine(WaitCallNextLevel());
       //startConfig.configRoom();
    }

    private void OnTriggerExit(Collider other)
    {
        entered = false;
        time = 6f;
        isWaiting = false;
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
        Debug.Log("exit NextLevelZone");
    }

    IEnumerator WaitCallNextLevel()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("5 seconds passed");
        if (isWaiting)
        {
            startConfig.configRoom();
            therapyZoneCol.levelIsRunning = false;
            Debug.Log("level is not running" + therapyZoneCol.levelIsRunning);
        }
       
    }
}
