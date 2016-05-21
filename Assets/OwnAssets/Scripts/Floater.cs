using UnityEngine;
using System.Collections;

public class Floater : MonoBehaviour {
	private float floatStrength = 0;
	public float randomRotationStrength;
    private bool isFloater = false;

    void Start() {
        Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
        rigidbody.gravityScale = 0.0f;
    }

	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag == "Player") {
			randomRotationStrength = - (collision.gameObject.transform.position.x);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
            isFloater = true;
            floatStrength = 10.0f;
		}
	}
	
	void FixedUpdate() {
        if (isFloater) {
            Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(Vector3.up * floatStrength);
            transform.Rotate(0, 0, randomRotationStrength);
        }
	}
}
