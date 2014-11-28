using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static bool isGameOver = false;
    public static bool isJustSetOnPause = false; //чтобы P не засчитываласб за два нажатия в апдейте
    public GameObject obj;
    public AudioSource bMusic;

    // Use this for initialization
    private void Start() {
        audio.Play();

        var o = Instantiate(obj, Camera.main.ScreenToWorldPoint(new Vector3(600, 600, 0)), Quaternion.identity) as
            GameObject;
        o.transform.position = new Vector3(o.transform.position.x, o.transform.position.y, 0);
    }

    // Update is called once per frame
    private void Update() {
        // нажатие P - пауза
        if (Input.GetKeyUp(KeyCode.P)) {
            if (!Pause.isPaused) SetOnPause();
            else ResumeGame();
        }

        if (isGameOver) {
            SetOnPause();
            if (Input.GetKeyUp(KeyCode.Space)) {
                isGameOver = false;
                Application.LoadLevel("test");
                ResumeGame();
            }
        }

        isJustSetOnPause = false;
    }

    private void SetOnPause() {
        Pause.isPaused = true;
        Time.timeScale = 0;
        bMusic.volume = 0.25f;
    }

    private void ResumeGame() {
        Pause.isPaused = false;
        Time.timeScale = 1;
        bMusic.volume = 1f;
    }
}