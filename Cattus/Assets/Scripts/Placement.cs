using UnityEngine;

public class Placement : MonoBehaviour {
    public float xOffset1, yOffset1;

    // Use this for initialization
    private void Start()
    {
        gameObject.transform.position =
            Camera.main.ScreenToViewportPoint(new Vector3(Camera.main.pixelWidth / 100 * xOffset1,
                Camera.main.pixelHeight / 100 * yOffset1, 1));
    }


}