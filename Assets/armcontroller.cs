using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armcontroller : MonoBehaviour
{
    private HingeJoint myHingeJoint;
   
    private float flickAngle = 70;

    // Use this for initialization
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();
   

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            SetAngle(this.flickAngle);
        }


    }
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}