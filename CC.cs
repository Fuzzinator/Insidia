using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CC : MonoBehaviour {

    public static Action <bool, Vector2> moveCC;
    public static Action stopCC;
    public float speed = 10.0f;
    public GameObject mover;
    public GameObject agent;
    public GameObject head;


    private bool isMoving = false;

    //public Rigidbody Character;

    //public float trans;
    //public float straffe;

    // Use this for initialization
    void Start () {
        moveCC += moveCCHandler;
        stopCC += StopCCHandler;
	}

    public void moveCCHandler(bool moving, Vector2 axis)
    {
        print("doingthings");
        isMoving = true;
        //SetDes.setMyDes();



        //if (!moving)
        //{
        //    fPS.transform.position = head.transform.position;
        //    fPS.transform.localEulerAngles = head.transform.localEulerAngles;
            
        //}
        //if(moving)
        //{
        //    guide.transform.parent = null;
        //}

        //fPS.transform.localEulerAngles = head.transform.localEulerAngles;
        //guide.transform.parent = fPS.transform;
        //trans = axis.x * speed;
        //straffe = axis.y * speed;
        //trans *= Time.deltaTime;
        //straffe *= Time.deltaTime;
        //fPS.transform.Translate(straffe, 0, trans);
        //guide.transform.parent = null;
    }
	
	// Update is called once per frame

        public void StopCCHandler()
    {
        mover.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        isMoving = false;
       
    }

	void Update () {
        if (isMoving)
        {
            mover.transform.localEulerAngles = new Vector3(mover.transform.localEulerAngles.x, head.transform.localEulerAngles.y, mover.transform.localEulerAngles.z);
        }
    }
}
