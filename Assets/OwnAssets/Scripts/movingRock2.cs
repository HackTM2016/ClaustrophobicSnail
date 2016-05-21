using UnityEngine;
using System.Collections;

public class movingRock2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	int count;
	int var=-1;


	// Update is called once per frame
	void Update () {
		count++;
		if (count == 50) {
			var = -var;
			count = 0;
		}
		transform.Translate(Vector3.left * Time.deltaTime*var);
		transform.Translate (Vector3.left * Time.deltaTime*var, Space.World);

	}
}
