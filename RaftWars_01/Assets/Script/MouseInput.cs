using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseInput : MonoBehaviour
{
    public Transform player;
    //public Transform muzzle;

    Vector3 angle;
    float speed;

    Vector3 mousePos;
    bool mousePressed = false;

    public BallMovement b;
    void Start()
    {
        b = new BallMovement();
    }


    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = player.position - mousePos;

        b.Angle = Mathf.Atan2(angle.y, angle.x)*Mathf.Rad2Deg;

       
        SpeedIncrement();
        
    }
    void SpeedIncrement()
    {
        if(Input.GetMouseButton(0))
        {
            mousePressed = true;
            speed += 0.5f;
            Debug.Log(speed);
            if (speed > 100.0f)
                speed = 0.0f;
        }
        if(Input.GetMouseButtonUp(0)&&mousePressed)
        {
            b.Speed = speed;
        }
    }

}
