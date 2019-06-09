using UnityEngine;
using System.Collections;
using Valve.VR;
using UnityEngine.XR;

public class FearManager : MonoBehaviour
{

    //public LevelManager levelManager;
    public GameObjectHandler gameObjectHandler;
    GameObject fear1;
    GameObject fear2;
    GameObject fear3;
    GameObject fearDistance;
    int fearDistanceNr;

    int subjectiveFear = 0;
    int objectiveFear = 0;
    int fearRes;

    Vector3 startPositionL;
    Vector3 startPositionR;
    //Vector3 endPositionL;
    float endPositionR;
    float distanceToPlayer;

    SteamVR_TrackedObject trackedObject;
    //Quaternion newRotation = Quaternion.identity;

    // Use this for initialization
    void Start()
    {
        Debug.Log("test");
        fear1 = GameObject.FindWithTag("fearlevel1");
        fear2 = GameObject.FindWithTag("fearlevel2");
        fear3 = GameObject.FindWithTag("fearlevel3");
        fearDistance = GameObject.FindWithTag("fearDistance");
        startPositionL = InputTracking.GetLocalPosition(XRNode.LeftHand);
        startPositionR = InputTracking.GetLocalPosition(XRNode.RightHand);
        trackedObject = GetComponent<SteamVR_TrackedObject>();
}

    // Update is called once per frame
    void Update()
    {
        endPositionR = InputTracking.GetLocalPosition(XRNode.RightHand).x;
        CalculateDistance();
    }

    public int getSubjectiveFear()
    {
        return subjectiveFear;
    }

    public void setSubjectiveFear(int fear)
    {
        subjectiveFear = fear;
    }

    public int getObjectiveFear()
    {
        return objectiveFear;
    }

    public void setObjectiveFear(int fear)
    {
        objectiveFear = fear;
    }

    public int calculateFearLevel(int subjectiveFear, int objectiveFear)
    {
        //fearRes = subjectiveFear + objectiveFear;
        fearRes = subjectiveFear; //TODO
        return fearRes;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");

        if (other.CompareTag("fearlevel1")) {
            setSubjectiveFear(1);
            Debug.Log("trigger fearlevel set to 1");
        }
        else if (other.CompareTag("fearlevel2")) {
            setSubjectiveFear(2);
            Debug.Log(" trigger fearlevel set to 2");
        }
        else if (other.CompareTag("fearlevel3"))
        {
            setSubjectiveFear(3);
            Debug.Log(" trigger fearlevel set to 3");
        }
    }

    private void OnTriggerExit(Collider other)
    {
       if(other.CompareTag("fearlevel1")|| other.CompareTag("fearlevel2") || other.CompareTag("fearlevel3"))
        {
            Debug.Log("trigger gate passed: " + getSubjectiveFear());
        }
        Destroy(gameObjectHandler.subjectiveFear);
        Debug.Log("trigger exit");

    }

    public void CalculateDistance()
    {
        float hmdPosition = InputTracking.GetLocalPosition(XRNode.Head).x;
        setFearDistance(endPositionR - hmdPosition);
        //Debug.Log("distance" + distanceToPlayer);
    }

    public float getFearDistance()
    {
        return distanceToPlayer;
    }

    public void setFearDistance(float distance)
    {
        distanceToPlayer = distance;
    }

}
