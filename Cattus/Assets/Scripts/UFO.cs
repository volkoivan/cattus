using UnityEngine;
using System.Collections;

public class UFO : Enemy {
	private float yPositionPercent = 1;
	public GameObject _player;
	// Use this for initialization
	void Start () {
		gameObject.transform.position = new Vector3 (_player.transform.position.x, Variables.ScreenTop, 1);
	}
	
	// Update is called once per frame
	void Update () {

		if (yPositionPercent > 0.75) {
						gameObject.transform.position = new Vector3 (_player.transform.position.x, 2*Variables.ScreenTop * yPositionPercent, 1);
						yPositionPercent -= 0.005f;
				} else {
						gameObject.transform.position = new Vector3 (_player.transform.position.x, 2*Variables.ScreenTop * yPositionPercent, 1);
				}
	}
}
