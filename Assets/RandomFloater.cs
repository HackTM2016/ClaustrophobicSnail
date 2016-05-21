using UnityEngine;
using System.Collections;

public class RandomFloater : MonoBehaviour {

    void FixedUpdate() {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(0.1f, 0.5f));
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.left * Random.Range(0.1f, 0.5f));
        transform.Rotate(0, 0, Random.Range(0f, 5f));
    }
}
