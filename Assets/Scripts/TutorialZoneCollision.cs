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
        Debug.Log("Ausgabe Next Level" + nextLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calculateStartLevel() {
        //TODO Level zuweisen je nach Angst, Level entspricht 1.Step von LevelManagern
        nextLevel = 1;
        Debug.Log("set next level to" + nextLevel);
    }

   public int getStartLevel(){
        Debug.Log("called getStartLevel");
        return nextLevel;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Tutorialzone");
        calculateStartLevel();
        Debug.Log(nextLevel + "nach calculate");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Left Tutorialzone");

    }
}
