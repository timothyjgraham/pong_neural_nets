using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {

	 //up and down keys (to be set in the Inspector)
	public KeyCode up;
	public KeyCode down;

	void FixedUpdate () {

		if(Input.GetKey(up)) {
			transform.Translate(new Vector2(0.0f, 0.1f));
		}

		if(Input.GetKey(down)){
			transform.Translate(new Vector2(0.0f, -0.1f));
		}
		
	}


}
