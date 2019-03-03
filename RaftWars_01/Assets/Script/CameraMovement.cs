using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ball)
        {
            Vector3 ballPos = new Vector3(ball.position.x, ball.position.y, this.transform.position.z);
            this.transform.position = ballPos;

        }
	}
}
