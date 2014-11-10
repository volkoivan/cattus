using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player: MonoBehaviour {

    public int Score;

    private void Start() {
        Score = 0;
    }

    private void Update() {
        UpdateControl();
    }

    private void UpdateControl() {
        if (Input.GetKey(KeyCode.RightArrow)) rigidbody2D.AddForce(new Vector2(20, 0));
        if (Input.GetKey(KeyCode.LeftArrow)) rigidbody2D.AddForce(new Vector2(-20, 0));
    }


    // IsTrigger вызывает следующие методы: OnTriggerEnter, OnTriggerExit, OnTriggerStay
    private void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("Collider action");
        if (col != null){
            if (col.gameObject.tag == "Enemy")
                Application.LoadLevel(Application.loadedLevel);
        }
    }
}