using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialZoneCollision : MonoBehaviour
{
    public int startLevel; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calculateStartLevel() {
        //TODO Level zuweisen je nach Angst, Level entspricht 1.Step von LevelManagern
        startLevel = 1;
        Debug.Log("set startlevel to" + startLevel);
    }

   public int getStartLevel(){
        Debug.Log("called getStartLevel");
        return startLevel;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Tutorialzone");
        calculateStartLevel();
        Debug.Log("Startlevel wurde auf " + startLevel + " nach calculate gesetzt");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Left Tutorialzone");

    }

    
}
