using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public float ballCurrentPos;

	// Update is called once per frame
	void Update () {

		ballCurrentPos = GameObject.Find("Ball").transform.position.x;

		if (transform.position.x < ballCurrentPos) {
			transform.position += new Vector3 (20 * 1 * Time.deltaTime, 0f, 0f );
		}

		else if (transform.position.x > ballCurrentPos) {
			transform.position -= new Vector3 (20 * 1 * Time.deltaTime, 0f, 0f );
		}

	}
}
