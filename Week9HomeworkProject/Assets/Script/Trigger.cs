using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject ball;
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
        print("Ouch! ");
        ball.transform.position = new Vector3(0, 5, 0);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 5, 0);
    }
}
