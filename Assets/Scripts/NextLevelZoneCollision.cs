using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelZoneCollision : MonoBehaviour
{
    public int aktuellerStep;
    public Level1Manager l1Manager;
    public Level2Manager l2Manager;
    public Level3Manager l3Manager;
    public TutorialZoneCollision tutorialZoneCollision;

    // Start is called before the first frame update
    void Start()
    {
        //nextStep = tutorial.getStartLevel();
        aktuellerStep = tutorialZoneCollision.nextLevel;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger bei NextLevelZone
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered nextlevelzone with next step = "+ aktuellerStep);
        
        switch (aktuellerStep) //benennung ist verwirrend
            {
                case 1:
                    l1Manager.setStep1();
                    aktuellerStep++;
                    Debug.Log("case1 nächster step: " + aktuellerStep);
                    break;
                case 2:
                    l1Manager.setStep2();
                    aktuellerStep++;
                    Debug.Log("case2 nächster step: " + aktuellerStep);
                    break;
                case 3:
                    l1Manager.setStep3();
                    aktuellerStep++;
                    break;
                case 4:
                    l1Manager.setStep4();
                    aktuellerStep++;
                    break;
                case 5:
                    l2Manager.setStep1();
                    aktuellerStep++;
                    break;
                case 6:
                    l2Manager.setStep2();
                    aktuellerStep++;
                    break;
                case 7:
                    l2Manager.setStep3();
                    aktuellerStep++;
                    break;
                case 8:
                    l3Manager.setStep1();
                    aktuellerStep++;
                    break;

                    //TODO weitere steps
            }
            Debug.Log("Switched level" + aktuellerStep);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit NextLevelZone");
    }
}
