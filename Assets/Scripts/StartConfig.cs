using UnityEngine;
using System.Collections;

public class StartConfig : MonoBehaviour
{
    public GameObjectHandler objectHandler;

    // Use this for initialization
    void Start()
    {
        startConfigRoom();
        Debug.Log("StartConfiguration");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startConfigRoom()
    {
        objectHandler.resetRoom();
        objectHandler.displayTutorialZone();
        objectHandler.startPositionZone.SetActive(false);
        objectHandler.displaySubjectiveFear();
    }

    public void configRoom()
    {
        objectHandler.resetRoom();
        objectHandler.startPositionZone.SetActive(true);

    }
}
