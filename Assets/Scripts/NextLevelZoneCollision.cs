using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelZoneCollision : MonoBehaviour
{
    public int nextStep;
    public Level1Manager l1Manager;
    public Level2Manager l2Manager;
    public Level3Manager l3Manager;
    public TutorialZoneCollision tutorialZoneCollision;

    // Start is called before the first frame update
    void Start()
    {
        //nextStep = tutorial.getStartLevel();
        nextStep = tutorialZoneCollision.getStartLevel();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger bei NextLevelZone
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered nextlevelzone with next step = "+ nextStep);
        setStep();
    }


    public void setStep(){
        switch (nextStep) //benennung ist verwirrend
        {
            case 1:
                l1Manager.setStep1();
                nextStep++;
                Debug.Log("case1 nächster step: " + nextStep);
                break;
            case 2:
                l1Manager.setStep2();
                nextStep++;
                Debug.Log("case2 nächster step: " + nextStep);
                break;
            case 3:
                l1Manager.setStep3();
                nextStep++;
                break;
            case 4:
                l1Manager.setStep4();
                nextStep++;
                break;
            case 5:
                l2Manager.setStep1();
                nextStep++;
                break;
            case 6:
                l2Manager.setStep2();
                nextStep++;
                break;
            case 7:
                l2Manager.setStep3();
                nextStep++;
                break;
            case 8:
                l3Manager.setStep1();
                nextStep++;
                break;

                //TODO weitere steps
        }
        Debug.Log("Switched level" + nextStep);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit NextLevelZone");

    }
}
