using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPositionZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public TherapyZoneCollision therapyZoneCol;
    public GameObjectHandler objectHandler;
    public FearManager fearManager;
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
        Debug.Log("entered startzone + level: " + levelManager.getLevel());
        //timeout 3s
        isWaiting = true;
        StartCoroutine(WaitCallNextLevel());
    }

    private void OnTriggerExit(Collider other)
    {
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
            levelManager.callNextLevel(levelManager.getLevel());
            therapyZoneCol.levelIsRunning = true;
            Debug.Log("level is running" + therapyZoneCol.levelIsRunning);
        }
    }
}
