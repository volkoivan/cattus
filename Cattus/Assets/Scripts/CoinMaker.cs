using UnityEditor;
using UnityEngine;

public class CoinMaker : MonoBehaviour {
    private float timer;
    public Coin objCoin;

    // Use this for initialization
    private void Start() {
    }

    // Update is called once per frame

    private void Update() {
        MakeCoins();
    }

    //каждые 
    public void MakeCoins() {
        timer += Time.deltaTime;
        if (timer > Random.Range(1f, 2f)) {
            timer = 0;
            Instantiate(objCoin);
        }
    }
}