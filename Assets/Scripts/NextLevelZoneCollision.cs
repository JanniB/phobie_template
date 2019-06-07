using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelZoneCollision : MonoBehaviour
{
    public int nextStep;
    public TutorialZoneCollision tutorialZoneCollision;

    // Start is called before the first frame update
    void Start()
    {
        //nextStep = tutorial.getStartLevel();
        //nextStep = tutorialZoneCollision.getStartLevel();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger bei NextLevelZone
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered nextlevelzone with next step = "+ nextStep);
        //setStep();
    }




    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit NextLevelZone");

    }
}
