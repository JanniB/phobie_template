using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalk : MonoBehaviour
{
    public GameObject spider;
    public GameObjectHandler gameObjectHandler;
    private float rotateSpeed = 2f;
    private float radius = 0.1f;
    private Vector3 center;
    private float angle;

    void Start()
    {
        center = spider.transform.position;
        if (gameObjectHandler.getCurrentFearObjectNr() > 6)
        {
            radius = 0.9f;
            rotateSpeed = 4f;
}
    }

    void Update()
    {
        angle += rotateSpeed * Time.deltaTime;
        var offset = new Vector3(Mathf.Sin(angle), spider.transform.position.y, Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
    }
}