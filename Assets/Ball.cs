using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// speed to be modified in the Inspector
	public float speed = 12.0f;

	void Start () {
	// give the ball some initial movement direction
	rigidbody2D.velocity = Vector2.one.normalized * speed;
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketHeight) {
    // ascii art:
    // ||  1 <- at the top of the racket
    // ||
    // ||  0 <- at the middle of the racket
    // ||
    // || -1 <- at the bottom of the racket
    return (ballPos.y - racketPos.y) / racketHeight;
	}

	void OnCollisionEnter2D(Collision2D col){
	// function to deal with collision with racket
	// i.e. 'pong' style angles of collision (top/middle/bottom of racket)
	//   col.gameObject is the racket
  //   col.transform.position is the racket's position
  //   col.collider is the racket's collider

	// Hit the LEFT racket?
	if (col.gameObject.name == "RacketLeft") {

		// play a sound
		col.gameObject.GetComponent<AudioSource>().Play();

		// calculate hit factor
		float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

		// Calculate direction, make length=1 via .normalized
        Vector2 dir = new Vector2(1, y).normalized;

		// Set Velocity with dir * speed
    rigidbody2D.velocity = dir * speed;
	}

	// Hit the right Racket?
    if (col.gameObject.name == "RacketRight") {

			// play a sound
			col.gameObject.GetComponent<AudioSource>().Play();

        // Calculate hit Factor
        float y = hitFactor(transform.position,
                            col.transform.position,
                            col.collider.bounds.size.y);

        // Calculate direction, make length=1 via .normalized
        Vector2 dir = new Vector2(-1, y).normalized;

        // Set Velocity with dir * speed
        rigidbody2D.velocity = dir * speed;
    }

	}

}
