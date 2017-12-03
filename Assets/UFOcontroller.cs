using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UFOcontroller : MonoBehaviour
{

    public float speed = -200.00f;
    public Rigidbody rb;
    public float dy;
    bool R = false;
    bool B = false;
    bool BC = false;
    bool BM = false;
    bool BB = false;
    bool BF = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (R == true)
        {
            Debug.Log("Rm");
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (B == true)
        {
            Debug.Log("B");
            transform.position += transform.forward * speed * Time.deltaTime;
        }



        if (BM == true)
        {
            Debug.Log("BM");
            transform.position -= transform.up * speed * Time.deltaTime;
        }

        if (BB == true)
        {
            Debug.Log("BB");
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (BF == true)
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
            transform.position -= transform.right * speed * Time.deltaTime;

        }


        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("z"))
        {
            Debug.Log("z");
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey("x"))
        {
            Debug.Log("x");
            transform.position += transform.up * speed * Time.deltaTime;
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



    public void Rmove()
    {
        R = true;
    }

    public void OnRU()
    {
        R = false;

    }


    public void Bmove()
    {
        Debug.Log("B");
        B = true;
    }

    public void BnRU()
    {

        B = false;
        Invoke("next", 1);



    }
    public void next()
    {
        Debug.Log("next");
        GetComponent<Animator>().SetTrigger("open");
        Invoke("next2", 1);

    }
    public void next2()
    {
        Debug.Log("next2");

        BM = true;
        Invoke("next3", 1);
    }
    public void next3()
    {
        BM = false;
        Debug.Log("next3");
        GetComponent<Animator>().SetTrigger("catch");
        Invoke("next4", 1);
    }
    public void next4()
    {
        BB = true;
        Invoke("next5", 1);

    }
    public void next5()
    {
        BB = false;
        BF = true;



    }


    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "HitBox")
        {
            Debug.Log("sa");
            BF = false;
            GetComponent<Animator>().SetTrigger("open");
            GetComponent<Animator>().SetTrigger("catch");

        }


    }
}