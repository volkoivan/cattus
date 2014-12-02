using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static int isGameOverCreated = 0;
    public static bool isGameOver = false;
    public static float Score = 0;
    public GameObject _gameover;
	public GameObject _gameovertext;
    public AudioSource bMusic;
    private float timerMultiplier;
    private float timerScore;
    public Font CustomFont;
    private bool isTextShown = false;
    private bool isMoneyAdded = false;



    // Use this for initialization
    private void Start() {
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
	//выводит статистику, если игра закончена
    private void CallTextOnGameOver() {
        gameObject.AddComponent("GUIText");
        gameObject.guiText.fontSize = 13;
        gameObject.guiText.color = Color.red;
        gameObject.guiText.font = CustomFont;
        gameObject.guiText.alignment = TextAlignment.Center;
        gameObject.guiText.anchor = TextAnchor.MiddleCenter;
		gameObject.guiText.text = "Game Over!\n\nScore: " + (LevelManager.Score).ToString ("0") + "\n\nPress Space \nto start again\n\nPress Esc \nto exit to Main Menu";


        gameObject.AddComponent<PlacementText>();
        var b = gameObject.GetComponent<PlacementText>();
        b.xOffset1 = 50;
        b.yOffset1 = 56.5f;

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
            if ((!isTextShown) && (GameOverWindow.isWindowCreated == 1)) {
                isTextShown = true;
                CallTextOnGameOver();
            }
            if (isGameOverCreated == 0) {
                GameOverMaker();
				//GameOverTextMaker();
                isGameOverCreated = 1;
            }
            if (Input.GetKeyUp(KeyCode.Space)) {
                isGameOver = false;
                Score = 0;
                Application.LoadLevel("test");
				isGameOverCreated = 0;
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