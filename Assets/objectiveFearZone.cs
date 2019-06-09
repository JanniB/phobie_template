using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectiveFearZone : MonoBehaviour
{
    public GameObjectHandler objectHandler;
    FearManager fearManager;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered objective fear zone");
        //timeout 5s
        StartCoroutine(WaitObjectiveFear());
    }

    private void OnTriggerExit(Collider other)
    {
        objectHandler.hideObjectiveFear();
        fearManager.CalculateDistance();
       //allgemeine angstdistanz berechnen
        objectHandler.displayStartPositionZone();
        Debug.Log("exit objectiveFearZone");
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
    }

    IEnumerator WaitObjectiveFear()
    {
        yield return new WaitForSeconds(3);
        objectHandler.displayObjectiveFear();

    }

}
