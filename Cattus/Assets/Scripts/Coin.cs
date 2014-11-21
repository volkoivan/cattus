using UnityEngine;

public class Coin : MonoBehaviour {
    public AudioClip CoinPickUp;

    // Use this for initialization
    private void Start() {
    }

    // Update is called once per frame
    private void Update() {
//	    transform.Translate(0, -0.02f, 0);
        transform.position += new Vector3(0, -0.02f, 0);
    }


    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            AudioSource.PlayClipAtPoint(CoinPickUp, transform.position);
            gameObject.SetActive(false);
        }
    }
}