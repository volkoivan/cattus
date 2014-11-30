using UnityEditorInternal;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public GameObject obj;
	public GameObject _gameover;
	public static int isGameOverCreated = 0;
    public static bool isGameOver = false;
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
        if (Input.GetKeyUp(KeyCode.P) && !isGameOver) {
            SetOnPause();
        }

        if (isGameOver) {
            SetOnPause();
			if (LevelManager.isGameOverCreated == 0){
				GameOverMaker();
				LevelManager.isGameOverCreated = 1;
			}
            if (Input.GetKeyUp(KeyCode.Space)) {
                isGameOver = false;
                Application.LoadLevel("test");
                ResumeGame();
            }
        }

        //Если на паузе и не проиграли, то можно продолжить

        if (Pause.isPaused == true && !isGameOver)
        {
            if (Input.GetKeyUp(KeyCode.P)) ResumeGame();
        }
    }
	public void GameOverMaker(){
		Instantiate(_gameover);
	}
    private void SetOnPause() {
        Pause.isPaused = true;
        Time.timeScale = 0;
    }

    private void ResumeGame() {
        Pause.isPaused = false;
        Time.timeScale = 1;
    }
}