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
        if (transform.position.y < Camera.main.ScreenToWorldPoint(new Vector3(0, -Screen.height/2, 0)).y) Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            Player.Money += 1;
            AudioSource.PlayClipAtPoint(CoinPickUp, transform.position);
            Destroy(gameObject);
        }
    }
}