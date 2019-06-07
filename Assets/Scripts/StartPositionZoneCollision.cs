using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPositionZoneCollision : MonoBehaviour
{
    public bool enteringStartZone = false;
    public LevelManager levelManager;
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
        Debug.Log("entered StartPositionZone + Level: " + levelManager.getLevel());
        enteringStartZone = true;

        levelManager.callNextLevel(levelManager.getLevel());
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit StartPositionZone");
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
        enteringStartZone = false;

    }
}
