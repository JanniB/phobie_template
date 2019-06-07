﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelZoneCollision : MonoBehaviour
{
    public bool enteringNextLevel = false;
    public LevelManager levelManager;
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
        Debug.Log("entered NextLevelZone");
       //3s timeout
       startConfig.configRoom();
    }

    private void OnTriggerExit(Collider other)
    {
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
        Debug.Log("exit NextLevelZone");
    }
}
