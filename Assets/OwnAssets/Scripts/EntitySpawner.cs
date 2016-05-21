using UnityEngine;
using System.Collections;

public class EntitySpawner : MonoBehaviour {

    public GameObject entityToSpawn;
    public float spawnFrequency;
    private float lastTimeSpawned;
    private float currentFixedTime;

    void FixedUpdate() {
        if ((currentFixedTime = Time.fixedTime) - lastTimeSpawned > .5f) {
            Instantiate(entityToSpawn, this.gameObject.transform.position, Quaternion.identity);
            lastTimeSpawned = currentFixedTime;
        }
    }
}
