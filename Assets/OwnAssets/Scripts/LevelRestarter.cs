using UnityEngine;
using System.Collections;

public class LevelRestarter : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        } else {
            Destroy(other.gameObject);
        }
    }
}
