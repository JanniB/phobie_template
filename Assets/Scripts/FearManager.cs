using UnityEngine;
using System.Collections;

public class FearManager : MonoBehaviour
{

   //public LevelManager levelManager;
    GameObject fear1;
    GameObject fear2;
    GameObject fear3;
    GameObject fearDistance;
    int fearDistanceNr;

    int subjectiveFear = 0;
    int objectiveFear = 0;
    int fearRes;

    // Use this for initialization
    void Start()
    {
        fear1 = GameObject.FindWithTag("fearlevel1");
        fear2 = GameObject.FindWithTag("fearlevel2");
        fear3 = GameObject.FindWithTag("fearlevel3");
        fearDistance = GameObject.FindWithTag("fearDistance");

    }

    // Update is called once per frame
    void Update()
    {

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
        if(other.gameObject.tag == "fearlevel1") {
            setSubjectiveFear(1);
            Debug.Log("fearlevel set to 1");
        }
        else if (other.gameObject.tag == "fearlevel2") {
            setSubjectiveFear(2);
            Debug.Log("fearlevel set to 2");
        }
        else if (other.gameObject.tag == "fearlevel3")
        {
            setSubjectiveFear(3);
            Debug.Log("fearlevel set to 3");
        }
    }

    private void OnTriggerExit(Collider other)
    {
       
        Debug.Log("");

    }
}
