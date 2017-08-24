using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePlayer : MonoBehaviour {

    public static Action<Vector2> movement;

    public float speed;

    public GameObject rig;

    public float forwardBack;
    public float straffe;

    public float inputX;
    public float inputY;


	// Use this for initialization
	void Start () {
        gameObject.transform.position = rig.transform.position;
        movement += MovementHandler;
		
	}

    void MovementHandler(Vector2 direction)
    {
        inputX = direction.x;
        inputY = direction.y;
        forwardBack = inputY * speed;
        straffe = inputX * speed;
        forwardBack *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, forwardBack);
    }
	
}
