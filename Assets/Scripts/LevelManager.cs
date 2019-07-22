using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int level;
    public GameObjectHandler objectHandler;
    public NextLevelZoneCollision nextLevelZoneCollision;
    public StartPositionZoneCollision startZoneCollision;
    public StartConfig startConfig;
    public FearManager fearManager;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Aktuelles Level in LM: " + level);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setLevel(int l)
    {
        level = l;
    }

    public int getLevel()
    {
        return level;
    }

   
    public void callNextLevel(int l) {
        level = l;
        switch (l)
        {
            case 1:
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                objectHandler.displayTerrarium();
                level++;
                break;
            case 2:
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                objectHandler.displayTerrarium();
                level++;
                break;
            case 3:
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                objectHandler.displayTerrarium();
                level++;
                break;
            case 4:
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                objectHandler.displayTerrarium();
                level++;
                break;
            case 5:
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                objectHandler.displayTerrarium();
                level++;
                break;
            case 6:
                objectHandler.displayNextLevelZone();
                objectHandler.setCurrentFearObject(level);
                objectHandler.displayTerrarium();
                level++;
                break;
            case 7:
                objectHandler.displayNextLevelZone();
                objectHandler.terrarium.SetActive(false);
                objectHandler.fearobjectZone.SetActive(true);
                objectHandler.setCurrentFearObject(level);
                level++;
                break;
            case 8:
                objectHandler.displayNextLevelZone();
                objectHandler.terrarium.SetActive(false);
                objectHandler.fearobjectZone.SetActive(true);
                objectHandler.setCurrentFearObject(level);
                level++;
                break;
        }
    }
}