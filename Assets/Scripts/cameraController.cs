using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime, 0, Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
