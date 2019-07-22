using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialZoneCollision : MonoBehaviour
{
    public GameObject tutorialZone;

    void Start()
    {
        tutorialZone = GameObject.FindWithTag("tutorialzone");
    }

    void Update()
    {
    }

    private void OnTriggerExit(Collider other)
    {
        tutorialZone.SetActive(false);
        Destroy(tutorialZone);
    }
}