using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform Ball;
    private Vector3 cameraOffset;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtBall = false;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - Ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Ball.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position,newPos,SmoothFactor);
        if (LookAtBall) {
            transform.LookAt(Ball);
        }
    }
}
