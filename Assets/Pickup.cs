using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pickup : MonoBehaviour {

    public Text text;
    private int score = 0;

    private void Awake() {
        text.text = "Score: 0";
    }
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Coin") {
            score += 10;
            text.text = "Score: " + score;
            Destroy(other.gameObject);
        }
    }
}
