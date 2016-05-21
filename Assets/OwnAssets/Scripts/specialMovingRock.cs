using UnityEngine;
using System.Collections;

public class specialMovingRock : MonoBehaviour {

    private int count;
    private float time;
    private float var = 100;
    public float delay = 0.0f;

    void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.transform.Translate(Vector3.left * time * var);
            other.gameObject.transform.Translate(Vector3.left * time * var, Space.World);
        }
    }

    void FixedUpdate() {
        if (delay <= 0) {
            count++;
            if (count == 50) {
                var = -var;
                count = 0;
            }
            time = Time.fixedDeltaTime;
            transform.Translate(Vector3.left * time * var);
            transform.Translate(Vector3.left * time * var, Space.World);
        } else {
            delay -= Time.fixedDeltaTime;
        }
    }
}
