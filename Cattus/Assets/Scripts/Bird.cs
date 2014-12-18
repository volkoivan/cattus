using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bird : Enemy {
    public float AdVel = 0.05f;
    private int Direction = -1;
    private bool isDirChanged = false;
    public float RandForce;
    public float RandPosY;
    public float RandPosX;

    // Use this for initialization
    private void Start() {
        RandPosY = Random.Range(80, 100);
        RandPosX = Convert.ToInt32(Random.Range(0f, 1.999f))*100;
        GetComponent<Placement>().xOffset1 = RandPosX;
        GetComponent<Placement>().yOffset1 = RandPosY;
        RandForce = Random.Range(50f, 150f);
        if (RandPosX > 90f) {
            RandForce *= -1;
            transform.localScale = new Vector3(transform.localScale.x*-1f,transform.localScale.y,transform.localScale.z);
        }
        rigidbody2D.AddForce(new Vector2(RandForce, 0));
        //rigidbody2D.velocity = new Vector2(HSpeed, 0);
    }

    // Update is called once per frame
    private void Update() {
        //if (Pause.isPaused == false) UpdateMovement();
    }

    private void UpdateMovement() {
       // gameObject.transform.position += new Vector3(HSpeed, VSpeed, 0);
        //VSpeed += AdVel*Direction;
        /*if (VSpeed > 0.12f && !isDirChanged) {
            Direction *= -1;
            isDirChanged = true;
        }
        if (VSpeed < -0.12f && !isDirChanged) {
            Direction *= -1;
            isDirChanged = true;
        }*/
        //if (VSpeed < 0.001f && VSpeed > -0.001f) isDirChanged = false;
        /* if (gameObject.transform.position.x > Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x)
            gameObject.transform.position =
                new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x*(-1),
                    gameObject.transform.position.y, gameObject.transform.position.z);*/
    }
}