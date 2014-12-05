using UnityEngine;
using System.Collections;

public class GameOverMenuText : MonoBehaviour {
	private string ControlKeysHelp = "Press Space to start again\nPress Esc to exit to Main Menu";
	// Use this for initialization
	void Start () {
		guiText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (!LevelManager.isGameOver) {
			guiText.text = "Game Over!\nScore: " + (LevelManager.Score).ToString ("0") + ControlKeysHelp;
		} 
	}
}
