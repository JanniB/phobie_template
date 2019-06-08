using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public StartPositionZoneCollision startzoneCol;
    public TherapyZoneCollision therapyZoneCol;
    public StartConfig startConfig;
    public GameObjectHandler objectHandler;
    bool isWaiting = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //3s
        isWaiting = true;
        StartCoroutine(WaitCallNextLevel());
       //startConfig.configRoom();
    }

    private void OnTriggerExit(Collider other)
    {
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
