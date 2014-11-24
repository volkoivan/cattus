using UnityEngine;

public class Control : MonoBehaviour {
    // Use this for initialization
    private void Start() {
    }

    // Update is called once per frame
    private void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) rigidbody2D.AddForce(new Vector2(5, 0));
        if (Input.GetKey(KeyCode.LeftArrow)) rigidbody2D.AddForce(new Vector2(-5, 0));
    }
}