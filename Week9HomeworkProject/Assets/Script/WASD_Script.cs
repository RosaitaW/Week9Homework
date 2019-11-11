using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Script : MonoBehaviour
{
    public float force = 0.1f;
    public KeyCode foward;
    public KeyCode back;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Jump;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bool hasInput = false;

        if (Input.GetKey(foward)) {
            rb.velocity = new Vector3(0, 0, force);
            hasInput = true;
        }
        if (Input.GetKey(back))
        {
            rb.velocity = new Vector3(0, 0, -force);
            hasInput = true;
        }
        if (Input.GetKey(Left))
        {
            rb.velocity = new Vector3(-force, 0, 0);
            hasInput = true;
        }
        if (Input.GetKey(Right))
        {
            rb.velocity = new Vector3(force, 0, 0);
            hasInput = true;
        }
        if (Input.GetKeyDown(Jump))
        {
            if (transform.position.y <= 10f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 3000);
            }
            hasInput = true;
        }
        if (!hasInput)
        {
            //rb.velocity = new Vector3(0, 0, 0);
            rb.velocity = rb.velocity * gravity;
        }
    }
}
