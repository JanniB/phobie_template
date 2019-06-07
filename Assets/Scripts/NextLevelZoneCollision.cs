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
        therapyZoneCol.levelIsRunning = false;
        Debug.Log("level is not running" + therapyZoneCol.levelIsRunning);
        //3s
        startConfig.configRoom();
    }

    private void OnTriggerExit(Collider other)
    {
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
        Debug.Log("exit NextLevelZone");
    }
}
