using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public int objectiveLevel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == GameObject.FindWithTag("trigger3")){
            setObjectiveLevel(3);
            Debug.Log("trigger3 " + getObjectiveLevel());
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
