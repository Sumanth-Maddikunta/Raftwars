using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour
{
    Rigidbody rb;

    //Ball variables
    float speed;
    float angle;

    public float Angle
    {
        set
        {
            angle = value;
        }
        get
        {
            return angle;
        }
    }
    public float Speed
    {
        set
        {
            speed = value;
        }
        get
        {
            return speed;
        }
    }

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //On mouse right click fire ball;
        if (Input.GetMouseButton(1))
            FireBall();
    }
    
    
    //Function to fire ball
    public void FireBall()
    {
        
        //Debug.Log(angle);
        rb.velocity = new Vector3(speed * Mathf.Cos(Mathf.Deg2Rad * angle), speed * Mathf.Sin(Mathf.Deg2Rad * angle), 0);
    }
}
