using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPositionZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public TherapyZoneCollision therapyZoneCol;
    public GameObjectHandler objectHandler;

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
        therapyZoneCol.levelIsRunning = true;
        Debug.Log("level is running" + therapyZoneCol.levelIsRunning);
        //timeout 3s
        StartCoroutine(WaitCallNextLevel());
        //levelManager.callNextLevel(levelManager.getLevel());

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit StartPositionZone");
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
    }

    IEnumerator WaitCallNextLevel()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("5 seconds passed");
        levelManager.callNextLevel(levelManager.getLevel());
    }
}
