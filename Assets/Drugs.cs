using UnityEngine;
using UnityStandardAssets.ImageEffects;
using System.Collections;

public class Drugs : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            Camera.FindObjectOfType<Camera>().GetComponent<VignetteAndChromaticAberration>().chromaticAberration = 15.5f;
            Destroy(this.gameObject);
        }
    }
}
