using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelZoneCollision : MonoBehaviour
{
    public int nextStep;
    public Level1Manager l1Manager = new Level1Manager();
    public Level2Manager l2Manager = new Level2Manager();
    public Level3Manager l3Manager = new Level3Manager();
    //public TutorialZoneCollision tutorial = new TutorialZoneCollision();

    // Start is called before the first frame update
    void Start()
    {
        //nextStep = tutorial.getStartLevel();
        l1Manager = GetComponent<Level1Manager>();
        l2Manager = GetComponent<Level2Manager>();
        l3Manager = GetComponent<Level3Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger bei NextLevelZone
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("headset"))
        {
            switch (nextStep)
            {
                case 1:
                    l1Manager.setStep1();
                    nextStep++;
                    break;
                case 2:
                    l1Manager.setStep2();
                    nextStep++;
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
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit NextLevelZone");
    }
}
