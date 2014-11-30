using UnityEngine;

public class LevelManager : MonoBehaviour {
	public GameObject _gameover;
	public static int isGameOverCreated = 0;
    public static bool isGameOver = false;
    public static bool isJustSetOnPause = false; //чтобы P не засчитываласб за два нажатия в апдейте
    public float Score = 0;
    public float ScoreMultiplier = 1.8f;
    public AudioSource bMusic;
    public GameObject obj;
    private float timerScore;
    private float timerMultiplier;
    private float scoreSpeed = 1f;

    // Use this for initialization
    private void Start() {
        audio.Play();
        var o = Instantiate(obj, Camera.main.ScreenToWorldPoint(new Vector3(600, 600, -10)), Quaternion.identity) as
            GameObject;
        o.transform.position = new Vector3(o.transform.position.x, o.transform.position.y, 0);
    }
    // Update is called once per frame
    private void Update() {
        Debug.Log(Score);
        PauseCheck();
        ScoreUpdater();
        MultiplierUpdater();
    }

    private void SetOnPause() {
        Pause.isPaused = true;
        Time.timeScale = 0;
        bMusic.volume = 0.25f;
    }

	public void GameOverMaker(){
		Instantiate(_gameover);
	}

    private void PauseCheck() {
				// нажатие P - пауза
				if (Input.GetKeyUp (KeyCode.P)) {
						if (!Pause.isPaused)
								SetOnPause ();
						else
								ResumeGame ();
				}

				if (isGameOver) {
						SetOnPause ();
						if (isGameOverCreated == 0) {
								GameOverMaker ();
								isGameOverCreated = 1;
							}		
						if (Input.GetKeyUp (KeyCode.Space)) {
										isGameOver = false;
										Application.LoadLevel ("test");
										ResumeGame ();
										isGameOverCreated = 0;
								}
						}
		}

    private void ResumeGame() {
        Pause.isPaused = false;
        Time.timeScale = 1;
        bMusic.volume = 1f;
    }

    //Увеличивает счет на ScoreMultiplayer каждую секунду

    private void ScoreUpdater() {
        if (!Pause.isPaused) {
            timerScore += Time.deltaTime;
            if (timerScore > scoreSpeed) {
                Score += 1;
                timerScore = 0;
            }
        }
    }

    //Увеличивает счет на ScoreMultiplayer каждую секунду

    private void MultiplierUpdater()
    {
        if (!Pause.isPaused)
        {
            timerMultiplier += Time.deltaTime;
            if (timerMultiplier > 2) {
                timerMultiplier = 0;
                scoreSpeed /= 2;
            }
        }
    }
}