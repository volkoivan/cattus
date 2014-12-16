using UnityEngine;

public class Bird : Enemy {
    public float AdVel = 0.1f;
    private int Direction = -1;

    // Use this for initialization
    private void Start() {
        rigidbody2D.velocity = new Vector2(HSpeed, 0);
    }

    // Update is called once per frame
    private void Update() {
        if (Pause.isPaused == false) UpdateMovement();
    }

    private void UpdateMovement() {
        gameObject.transform.position += new Vector3(HSpeed, VSpeed, 0);
        VSpeed += AdVel*Direction;
        if (VSpeed > 0.1f) Direction *= -1;
        if (VSpeed < -0.1f) Direction *= -1;
       /* if (gameObject.transform.position.x > Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x)
            gameObject.transform.position =
                new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x*(-1),
                    gameObject.transform.position.y, gameObject.transform.position.z);*/
    }
}