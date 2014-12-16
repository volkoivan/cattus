using UnityEngine;
using System.Collections;

public class Variables: MonoBehaviour {
	public static float ScreenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
	public static float ScreenTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
	public static float ScreenBot = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
	public static float ScreenLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;

    public static int CoinsCounter = 0;
	// Use this for initialization
    void Start()
    {
        ScreenLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
        ScreenBot = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
        ScreenTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
        ScreenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
