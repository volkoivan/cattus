using UnityEngine;
using System.Collections;

public class PlacementText : MonoBehaviour {
    public float xOffset1, yOffset1;

    // Use this for initialization
    private void Start() {
        gameObject.transform.position =
            Camera.main.ScreenToViewportPoint(new Vector3(Camera.main.pixelWidth/100*xOffset1,
                Camera.main.pixelHeight/100*yOffset1, gameObject.transform.position.z));
    }
}
