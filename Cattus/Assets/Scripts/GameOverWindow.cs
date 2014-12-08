using UnityEngine;


public class GameOverWindow: MonoBehaviour {
	// Use this for initialization
	public static int isWindowCreated;
	public void Start () {
		//transform.position = new Vector3 (0,Variables.ScreenTop+gameObject.renderer.bounds.size.y/2,0);
		transform.localScale = new Vector3 (0, 0, 1);
		transform.position = new Vector3 (0, 0, 1);
		isWindowCreated = 0;

		//gameObject.rigidbody2D.AddForce(new Vector2 (0, -1000));
	}
	
	// Update is called once per frame
	void Update () {
				//if (gameObject.transform.position.y > gameObject.renderer.bounds.size.y/2)
				//gameObject.transform.position +=new Vector3(0,-0.5f,0);
				if (gameObject.transform.localScale != new Vector3 (0.22f, 0.22f, 1)) {
						gameObject.transform.localScale += new Vector3 (0.02f, 0.02f, 0);
				} else 
						if (LevelManager.isGameOver) {
						isWindowCreated = 1;
				} else {
						isWindowCreated = 0;
				}
		}
}


