using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialZoneCollision : MonoBehaviour
{
    public int nextLevel; 
    // Start is called before the first frame update
    void Start()
    {
        calculateStartLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calculateStartLevel() {
        //TODO Level zuweisen je nach Angst, Level entspricht 1.Step von LevelManagern
        nextLevel = 1;
    }

   public int getStartLevel(){
        return nextLevel;
    }
}
