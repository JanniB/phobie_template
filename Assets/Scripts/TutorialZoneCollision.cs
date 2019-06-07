using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public int fearRes;

    // Start is called before the first frame update
    void Start()
    {
        //Angsteinschätzung subjektiv
        //Angsteinschätzung objektiv
    }

    // Update is called once per frame
    void Update()
    {

    }

    // subjektive + objekte Angstparameter mitteln 
    // anhand Startlevel (LevelManager) zuweisen
    public void calculateStartLevel() {
        //TODO if wert > < x dann setLevel.
        fearRes = 1;
        levelManager.setLevel(fearRes);
        Debug.Log("Set startlevel to" + fearRes  + " " + levelManager.getLevel());
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Tutorialzone");
        calculateStartLevel();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Left Tutorialzone");

    }

    
}
