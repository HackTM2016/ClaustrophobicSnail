using UnityEngine;
using System.Collections;

public class Awakener : MonoBehaviour {

    public float timeToAwakening = 0.0f;
    private float elapsedTime = 0.0f;
    private float lastTime = 0.0f;

    void FixedUpdate() {
        elapsedTime += Time.fixedDeltaTime - lastTime;
        lastTime = Time.fixedDeltaTime;
        if(elapsedTime > timeToAwakening) {
            gameObject.GetComponent<Rigidbody2D>().WakeUp();
        }

    }
}
