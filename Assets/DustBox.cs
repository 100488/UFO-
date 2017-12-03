using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DustBox : MonoBehaviour
{
    private GameObject scoreText;
    private int score = 0;
    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
    }
    void OnCollisionStay(Collision other)
    {

        Destroy(other.gameObject);
        this.score += 1;

        this.scoreText.GetComponent<Text>().text = "Score " + this.score;

    }

    // Update is called once per frame
    void Update()
    {
      


        

    }
}