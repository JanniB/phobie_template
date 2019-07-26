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
    GameObject test;
    public GameObject spiderPrefab;
    public GameObject Spider8;
    public Transform spawnPoint;

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
        if(levelIsRunning == true)
        {
            int levelrunning = levelManager.getLevel()-1;
            levelManager.callNextLevel(levelrunning);
            if( levelManager.getLevel()-1 == 8){
                Destroy(startzoneCol.test);
                var Instance = Instantiate(spiderPrefab, spawnPoint.position, spawnPoint.rotation);
                Instance.transform.parent = Spider8.transform;
                test = Instance;
            }
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
        Destroy(startzoneCol.test);
        Destroy(test);
    }
}

