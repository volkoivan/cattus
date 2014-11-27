using UnityEditorInternal;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public GameObject obj;

    // Use this for initialization
    private void Start() {
        audio.Play();

        var o =
            Instantiate(obj, Camera.main.ScreenToWorldPoint(new Vector3(600, 600, 0)), Quaternion.identity) as
                GameObject;
        o.transform.position = new Vector3(o.transform.position.x, o.transform.position.y, 0);
    }

    // Update is called once per frame
    private void Update() {
        if (Pause.isPaused == true)
        {
            Time.timeScale = 0;
            if (Input.GetKeyUp(KeyCode.Space)) {
                Application.LoadLevel("test");
                Pause.isPaused = false;
                Time.timeScale = 1;
            }
        }

    }
}