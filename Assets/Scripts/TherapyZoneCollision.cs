using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TherapyZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public StartConfig startConfig;
    public StartPositionZoneCollision startzoneCol;
    public NextLevelZoneCollision nextlevelCol;
    public int aktuellerStep;
    public bool levelIsRunning;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered Therapiezone");
        if(levelIsRunning == true)
        {
            int levelrunning = levelManager.getLevel()-1;
            levelManager.callNextLevel(levelrunning);
        }
        else if (levelIsRunning == false)
        {
            startConfig.configRoom();
            levelManager.setLevel(levelManager.getLevel());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        startConfig.configRoom();
    }
}

