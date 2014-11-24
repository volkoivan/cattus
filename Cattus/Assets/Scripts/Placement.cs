using UnityEngine;

public class Placement : MonoBehaviour {
    public float xOffset;
    public float yOffset;
    // Use this for initialization
    private void Start() {
        gameObject.transform.position =
            Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth / 100 * xOffset, Camera.main.pixelHeight / 100 * yOffset, 1));
    }

    // Update is called once per frame
    private void Update() {
    }
}