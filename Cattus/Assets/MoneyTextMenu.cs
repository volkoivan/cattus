using UnityEngine;
using System.Collections;

public class MoneyTextMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    guiText.text = "Your coins: " + Variables.CoinsCounter;
	}
}
