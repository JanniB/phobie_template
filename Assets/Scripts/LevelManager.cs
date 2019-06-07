using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public int level;
    public GameObjectHandler objects;

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
               /*displayTerrarium();
                showCrossMarker();
                showStartPositionMarker();
                fearobject.setCurrentFearObject(level);
                fearobject.nextFearObject(level);*/
                level++;
                break;
            case 2:
                level++;
                break;
            case 3:
                level++;

                break;
            case 4:

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
        Debug.Log("Switched level" + level);
    }


 
}
