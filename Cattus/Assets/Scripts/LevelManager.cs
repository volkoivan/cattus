using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static int isGameOverCreated = 0;
    public static bool isGameOver = false;
    public static float Score = 0;
    public GameObject _gameover;
    public AudioSource bMusic;
    private float timerMultiplier;
    private float timerScore;
    public Font CustomFont;
    private bool isTextShown = false;
    private bool isMoneyAdded = false;
    public ParticleSystem particle_Start;



    // Use this for initialization
    private void Start() {
        Instantiate(particle_Start);
        audio.Play();
    }

    // Update is called once per frame
    private void Update() {
        PauseCheck();
        ScoreUpdater();
        CheckEscape();
        //MultiplierUpdater();
        GameOverCheck();
    }

    private void SetOnPause() {
        Pause.isPaused = true;
        Time.timeScale = 0;
        bMusic.volume = 0.25f;
    }

    private void CallTextOnGameOver() {
        gameObject.AddComponent("GUIText");
        gameObject.guiText.fontSize = 16;
        gameObject.guiText.color = Color.black;
        gameObject.guiText.font = CustomFont;
        gameObject.guiText.alignment = TextAlignment.Center;
        gameObject.guiText.anchor = TextAnchor.MiddleCenter;
        gameObject.guiText.text = "Press Space to restart\nPress Esc to go to the Main Menu";


        gameObject.AddComponent<PlacementText>();
        var b = gameObject.GetComponent<PlacementText>();
        b.xOffset1 = 50;
        b.yOffset1 = 40;

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
            if (!isMoneyAdded) {
                isMoneyAdded = true;
                Variables.CoinsCounter += Player.Money;
            }
            SetOnPause();
            if (!isTextShown) {
                isTextShown = true;
                CallTextOnGameOver();
            }
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

    private void CheckEscape() {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isGameOver = false;
            Score = 0;
            ResumeGame();
            Application.LoadLevel("Main_Menu");
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