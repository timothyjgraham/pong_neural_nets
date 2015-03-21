using UnityEngine;
using System.Collections;

public enum ePlayer
{
	Top,
	Bottom
}

public class Player : MonoBehaviour {

	public float speed = 15f;
	public ePlayer player;

	// Update is called once per frame
	void Update () {
		float inputSpeed = 0f;

		if (player==ePlayer.Top) {
			inputSpeed = Input.GetAxisRaw("TopPlayer");
		}

		else if (player==ePlayer.Bottom) {
			inputSpeed = Input.GetAxisRaw("BottomPlayer");
		}

		transform.position += new Vector3 (inputSpeed * speed * Time.deltaTime, 0f, 0f );

	}
}
