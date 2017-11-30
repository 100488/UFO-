using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOcontroller : MonoBehaviour {

    public float speed = 4.0f;
    public Rigidbody rb;
    public float dy;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(x, 0, z);
        if (Input.GetKey("z"))
        {
            Debug.Log("z");
            this.rb.AddForce(0, -1, 0);
        }
        if (Input.GetKey("x"))
        {
            Debug.Log("x");
            this.rb.AddForce(0, 10, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("s");
            GetComponent<Animator>().SetTrigger("open");
        }
        if (Input.GetKeyDown("c"))
        {
            Debug.Log("c");
            GetComponent<Animator>().SetTrigger("catch");
        }
    }
}
