        using System.Collections.Generic;
        using UnityEngine;
        using UnityEngine.XR;

public class CameraMovement : MonoBehaviour
    {
        Vector3 lastPos = Vector3.zero;
        public float speed = 1.4f;

        void Start()
        {
        }

        void Update()
        {
            if (lastPos == Vector3.zero) lastPos = transform.position;
            var offset = transform.position - lastPos;
            offset.y = 0;
            transform.parent.position += offset * speed;
            lastPos = transform.position;
        }
    }
