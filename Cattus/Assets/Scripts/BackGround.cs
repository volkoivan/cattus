using UnityEngine;

public class BackGround : MonoBehaviour {
    // Use this for initialization
    private void Start() {
        transform.position = new Vector3(0,
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, 0, 0)).y + gameObject.renderer.bounds.size.y/2,
            transform.position.z);
        rigidbody2D.velocity = (new Vector2(0, -0.2f));
    }


    // Update is called once per frame
    private void Update() {
        if (!Pause.isPaused)
            transform.position +=
                new Vector3(
                    -Player.direction*0.00003f*
                    (gameObject.renderer.bounds.size.x/2 -
                     Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, 0, 0)).x)/
                    Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, 0, 0)).x, 0, 0);
    }
}