using UnityEngine;

public class PlacementMenu : MonoBehaviour {
    public float xOffset1, yOffset1;

    // Use this for initialization
    private void Start() {
        gameObject.transform.position =
            Camera.main.ScreenToViewportPoint(new Vector3(Screen.width * xOffset1 / 100,
                Screen.height * yOffset1 / 100, 1));
    }
}