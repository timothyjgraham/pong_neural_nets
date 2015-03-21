using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public Vector3 initialImpulse;

    void Start() {
        // Initial Velocity
        rigidbody.AddForce(initialImpulse, ForceMode.Impulse);
    }

		void Update() {
			
		}
}
