using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOcontroller : MonoBehaviour {

    public float speed = 1000.0f;
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
        if (Input.GetKeyDown("z"))
        {
            Debug.Log("z");
            this.transform.position += new Vector3(0, dy, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("s");
            GetComponent<Animator>().SetTrigger("catch");
        }
    }
}
