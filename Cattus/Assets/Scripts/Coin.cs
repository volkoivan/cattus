using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public AudioClip CoinPickUp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//	    transform.Translate(0, -0.02f, 0);
	    transform.position += new Vector3(0, -0.02f, 0);
    }


    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            (col.GetComponent<Player>()).Score++;
            AudioSource.PlayClipAtPoint(CoinPickUp, transform.position);
            gameObject.SetActive(false);
        }
    }
}
