using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialZoneCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public GameObjectHandler objectHandler;
    public GameObject tutorialZone;
    FearManager fearManager;
    public int fearRes;

    // Start is called before the first frame update
    void Start()
    {
        tutorialZone = GameObject.FindWithTag("tutorialzone");
        //Angsteinschätzung subjektiv
        //Angsteinschätzung objektiv
    }

    // Update is called once per frame
    void Update()
    {

    }

  
       // levelManager.setLevel(fearRes);
        //Debug.Log("Set startlevel to" + fearRes + " " + levelManager.getLevel());
       

    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Tutorialzone");
        //objective Fear display
    }

    private void OnTriggerExit(Collider other)
    {
        tutorialZone.SetActive(false);
        Destroy(tutorialZone);
        Debug.Log("Left Tutorialzone");

    }

    
}
