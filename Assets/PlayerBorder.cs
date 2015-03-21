using UnityEngine;
using System.Collections;

public class PlayerBorder : MonoBehaviour {

	public ePlayer player;
	public ScoreUI score;


	void OnCollisionEnter(Collision col)
	{
		Ball ball = col.gameObject.GetComponent<Ball>();
		if (ball != null) {
			ball.transform.position = new Vector3 (5f, 1f, 9f);

			if (player == ePlayer.Top) score.scorePlayerBottom++;
			else if (player == ePlayer.Bottom) score.scorePlayerTop++;

		}
	}

}
