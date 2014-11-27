using UnityEngine;

public class SpacePressed : MonoBehaviour {
    // Use this for initialization
    private void Start() {
    }

    // Update is called once per frame
    private void Update() {
        if (Input.GetKeyUp(KeyCode.Space)) Application.LoadLevel("Test");
    }
}