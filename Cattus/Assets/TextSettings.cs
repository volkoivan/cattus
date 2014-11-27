using UnityEngine;
using System.Collections;

public class TextSettings : MonoBehaviour {

    public GUIStyle CustomFontStyle;
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
