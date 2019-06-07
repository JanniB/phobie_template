using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public int level;
    public GameObjectHandler objectHandler;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Aktuelles Level in LM: " + level);
        callNextLevel(level);
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void setLevel(int l)
    {
        level = l;
        Debug.Log("Level is set to: " + level);
    }

    public int getLevel()
    {
        return level;
    }

   
    public void callNextLevel(int level) {
        switch (level)
        {
            case 1:
                Debug.Log("Level " + level + "loading");
                objectHandler.displayTerrarium();
                objectHandler.displayCrossMarker();
                objectHandler.displayStartPositionZone();
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                level++;
                break;
            case 2:
                Debug.Log("Level " + level + "loading");
                objectHandler.displayTerrarium();
                objectHandler.displayCrossMarker();
                objectHandler.displayStartPositionZone();
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                level++;
                break;
            case 3:
                Debug.Log("Level " + level + "loading");
                objectHandler.displayTerrarium();
                objectHandler.displayCrossMarker();
                objectHandler.displayStartPositionZone();
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                level++;

                break;
            case 4:
                Debug.Log("Level " + level + "loading");
                objectHandler.displayTerrarium();
                objectHandler.displayCrossMarker();
                objectHandler.displayStartPositionZone();
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                level++;
                break;
            case 5:
                level++;

                break;
            case 6:
                //...terrarium.SetActive(false);
                level++;

                break;
            case 7:
                level++;

                break;
            case 8:
                level++;

                break;

                //TODO weitere steps
        }
    }


 
}
