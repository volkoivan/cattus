using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static int isGameOverCreated = 0;
    public static bool isGameOver = false;
    public static float Score = 0;
    public GameObject _gameover;
    public AudioSource bMusic;
    private float timerMultiplier;
    private float timerScore;

    // Use this for initialization
    private void Start() {
        audio.Play();
    }

    // Update is called once per frame
    private void Update() {
        PauseCheck();
        ScoreUpdater();
        //MultiplierUpdater();
        GameOverCheck();
    }

    private void SetOnPause() {
        Pause.isPaused = true;
        Time.timeScale = 0;
        bMusic.volume = 0.25f;
    }

    private void PauseCheck() {
        // нажатие P - пауза
        if (Input.GetKeyUp(KeyCode.P)) {
            if (!Pause.isPaused) SetOnPause();
            else ResumeGame();
        }
    }

    private void GameOverCheck() {
        if (isGameOver) {
            SetOnPause();
            if (isGameOverCreated == 0) {
                GameOverMaker();
                isGameOverCreated = 1;
            }
            if (Input.GetKeyUp(KeyCode.Space)) {
                isGameOver = false;
                Score = 0;
                Application.LoadLevel("test");
                ResumeGame();
            }
        }
    }

    public void GameOverMaker() {
        Instantiate(_gameover);
    }


    private void ResumeGame() {
        Pause.isPaused = false;
        Time.timeScale = 1;
        bMusic.volume = 1f;
    }

//Увеличивает счет на ScoreMultiplayer каждую секунду


    private void ScoreUpdater() {
        if (!Pause.isPaused) {
            Score += Time.deltaTime*5;
        }
    }
}

//Увеличивает счет на ScoreMultiplayer каждую секунду

/* private void MultiplierUpdater()
    {
        if (!Pause.isPaused)
        {
            timerMultiplier += Time.deltaTime;
            if (timerMultiplier > 2) {
                timerMultiplier = 0;
                scoreSpeed /= 1.2f;
            }
        }
    }
    */