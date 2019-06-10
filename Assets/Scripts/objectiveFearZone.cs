using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectiveFearZone : MonoBehaviour
{
    public GameObjectHandler objectHandler;
    public ControllerMovement controller;
    public List<GameObject> objectiveFearList = new List<GameObject>();
    public GameObject[] objectiveFearObjects;
    // Start is called before the first frame update
    void Start()
    {
        objectiveFearObjects = GameObject.FindGameObjectsWithTag("fearDistance");

        foreach (GameObject g in objectiveFearObjects)
        {
            objectiveFearList.Add(g);

            g.SetActive(false);
        }
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
        hideObjectiveFear();
        controller.calculateDistance();
       //allgemeine angstdistanz berechnen
        objectHandler.displayStartPositionZone();
        Debug.Log("exit objectiveFearZone");
        //wird ausgeblendet in startConfigRoom daher nie aufgerufen
    }

    IEnumerator WaitObjectiveFear()
    {
        yield return new WaitForSeconds(3);
        displayObjectiveFear();

    }

    public void hideObjectiveFear()
    {
        foreach (GameObject g in objectiveFearList)
        {
            g.SetActive(false);
        }

        Debug.Log("hide objective fear");
    }

    public void displayObjectiveFear()
    {
        foreach (GameObject g in objectiveFearObjects)
        {
            objectiveFearList.Add(g);

            g.SetActive(true);
        }
    }

}
