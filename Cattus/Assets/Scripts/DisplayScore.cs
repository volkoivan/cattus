using UnityEditor;
using UnityEngine;
using System.Collections;

public class DisplayScore : MonoBehaviour {
    public GUIStyle style;
    public Texture2D Rectangle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    guiText.text = "Score: " + (LevelManager.Score).ToString("0") + "\nCoins: " + (Player.Money).ToString();
	}
    void OnGUI()
    {
    }

}
