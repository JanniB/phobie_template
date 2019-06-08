        using System.Collections.Generic;
        using UnityEngine;
        using UnityEngine.XR;

public class CameraMovement : MonoBehaviour
    {
        Vector3 lastPos = Vector3.zero;
    public float speed = 0.4f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        /*void Update()
        {
            transform.position = InputTracking.GetLocalPosition(XRNode.CenterEye); //* 2.0;
            //transform.rotation
        }*/



        void Update()
        {
            //The headset initializes at Vector3.zero, and remains there during Start(), so initialize lastPos here
            if (lastPos == Vector3.zero) lastPos = transform.position;
            var offset = transform.position - lastPos;
            offset.y = 0;
            transform.parent.position += offset * speed;
            lastPos = transform.position;
        }
    }
