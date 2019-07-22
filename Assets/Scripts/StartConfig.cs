using UnityEngine;
using System.Collections;

public class StartConfig : MonoBehaviour
{
    public GameObjectHandler objectHandler;

    void Start()
    {
        startConfigRoom();
    }

    void Update()
    {
    }

    public void startConfigRoom()
    {
        objectHandler.resetRoom();
        objectHandler.displayTutorialZone();
        objectHandler.startPositionZone.SetActive(false);
        objectHandler.displaySubjectiveFear();
        objectHandler.therapyZone.SetActive(false);
        objectHandler.fearobjectZone.SetActive(false);
        objectHandler.hideCurvedArrow();
        objectHandler.hideWayBack();
    }

    public void configRoom()
    {
        objectHandler.resetRoom();
        objectHandler.startPositionZone.SetActive(true);
    }
}