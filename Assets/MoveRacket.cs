using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {

	 //up and down keys (to be set in the Inspector)
	public KeyCode left;
	public KeyCode right;

	void FixedUpdate () {

		if(Input.GetKey(left)) {
			transform.Translate(new Vector2(0.0f, 0.1f));
		}

		if(Input.GetKey(right)){
			transform.Translate(new Vector2(0.0f, -0.1f));
		}

	}


}
