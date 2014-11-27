using UnityEngine;

public class TextSettings : MonoBehaviour {
    public GUIStyle CustomFontStyle;
<<<<<<< HEAD
    public GUIText GuiText, FinalScore, GameOver, Restart;
	// Use this for initialization
	void Start () {
		GameOver.text="Game Over";
		FinalScore.text="Your score is "+Player.Score;
		Restart.text="Press Enter to start again";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
=======
    public GUIText GuiText;
    // Use this for initialization
    private void Start() {
    }

    // Update is called once per frame
    private void Update() {
    }
}
>>>>>>> 5ad25376f95b8518d5f351d79e8ae3abff215384
