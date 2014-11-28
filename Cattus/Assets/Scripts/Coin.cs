using UnityEngine;

public class Coin : MonoBehaviour {
    public AudioClip CoinPickUp;

    // Use this for initialization
    private void Start() {
        transform.position =
            Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Screen.height,
                1));
    }

    // Update is called once per frame
    private void Update() {
        if (Pause.isPaused == false) transform.position += new Vector3(0, -0.04f, 0);
    }


    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
			Player.Score += 10;
            AudioSource.PlayClipAtPoint(CoinPickUp, transform.position);
            Destroy(gameObject);
        }
    }
}