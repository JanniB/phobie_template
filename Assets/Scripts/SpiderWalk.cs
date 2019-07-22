using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalk : MonoBehaviour
{
    Vector3 Pos1;
    Vector3 Pos2;
    Vector3 Pos3;

    float speed = 0.2f;
    public GameObject spider;
    public GameObjectHandler gameObjectHandler;
    private float rotateSpeed = 2f;
    private float radius = 0.1f;
    private Vector3 center;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("enter start walk");
        center = spider.transform.position;
        Debug.Log("TESTETSESTSSETSTSETSTSET" + gameObjectHandler.getCurrentFearObjectNr());

        if (gameObjectHandler.getCurrentFearObjectNr() > 6)
        {
           //Debug.Log("TESTETSESTSSETSTSETSTSET" + gameObjectHandler.getCurrentFearObjectNr());
            radius = 0.9f;
            rotateSpeed = 4f;
}
    }

    // Update is called once per frame
    void Update()
    {
        angle += rotateSpeed * Time.deltaTime;
        var offset = new Vector3(Mathf.Sin(angle), spider.transform.position.y, Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
    }
}
