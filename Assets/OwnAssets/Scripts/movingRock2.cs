using UnityEngine;
using System.Collections;

public class movingRock2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    public int count = 50;
    public float var = 1;
    public float delay = 0.0f;

    private float time;


    void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.transform.Translate(- Vector3.up * time * var);
            other.gameObject.transform.Translate(- Vector3.up * time * var, Space.World);
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
            transform.Translate(Vector3.up * time * var);
            transform.Translate(Vector3.up * time * var, Space.World);
        } else {
            delay -= Time.fixedDeltaTime;
        }
    }
}
