using UnityEngine;

public class Player : MonoBehaviour {
    public static int Money;
    public static int direction = -1;
    public float objScale = 1;

    private void Start() {
        Money = 0;
        direction = 1; //  1: right;   -1:left;
        transform.localScale = new Vector3(-objScale, objScale, objScale);
        rigidbody2D.AddForce(new Vector2(100, 0));
        //Debug.Log(Camera.main.orthographicSize);
        //Debug.Log(Camera.main.aspect*Camera.main.orthographicSize);
    }

    private void Update() {
        UpdateControl();
    }

    private void UpdateControl() {
		//Debug.Log (Variables.ScreenRight + "RIGHT" + gameObject.transform.position.x);
		//Debug.Log (gameObject.renderer.bounds.size.x + "test");
        if ((Input.GetKeyUp(KeyCode.Space) && !Pause.isPaused) ||
            ((direction == 1) && ((transform.position.x+renderer.bounds.size.x/2) >= Variables.ScreenRight)) ||
            ((direction == -1) && ((transform.position.x-renderer.bounds.size.x/2) <= Variables.ScreenLeft))) {
            direction *= -1;
            rigidbody2D.AddForce(new Vector2(200*direction, 0));
            transform.localScale = new Vector3(-objScale*direction, objScale, objScale);
        }
    }

    private void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("Collider action");
        if (col != null) {
            if (col.gameObject.tag == "Enemy") {
                LevelManager.isGameOver = true;

            }
        }
    }

    // IsTrigger вызывает следующие методы: OnTriggerEnter, OnTriggerExit, OnTriggerStay
}