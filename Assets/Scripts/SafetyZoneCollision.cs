using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyZoneCollision : MonoBehaviour
{
    public GameObject fearObject;
    public GameObject cross;

    // Start is called before the first frame update
    void Start()
    {
        fearObject = GameObject.FindWithTag("SpiderStep2"); //spezielles fearobjekt setzen je nach step

        cross = GameObject.FindWithTag("cross");
        fearObject.SetActive(false);
        //hier fearlevel festlegen je nach Angsteinschätzung, aus tutorial holen


    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered Therapiezone");
        fearObject.SetActive(true);
        cross.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("entered Safety Area");
        fearObject.SetActive(false);
        cross.SetActive(true);
       
    }

    //Buttons anvisieren, next level holen: public int nextStep; public NextLevelZoneCollision nextLevelZone = new NextLevelZoneCollision();

}

