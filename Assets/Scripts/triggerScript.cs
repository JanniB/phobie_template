using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public int objectiveLevel;

    void Start()
    {
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == GameObject.FindWithTag("trigger3")){
            setObjectiveLevel(3);
        }
        else if(other == GameObject.FindWithTag("trigger2")){
            setObjectiveLevel(2);
        }
        else{
            setObjectiveLevel(1);
        }
    }

    public void setObjectiveLevel(int level) {
        this.objectiveLevel = level;
    }

    public int getObjectiveLevel(){
        return objectiveLevel;
    }
}