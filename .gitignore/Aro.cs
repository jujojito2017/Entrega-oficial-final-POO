using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aro : destructor {

	public float speed = 1;
	private int direction = 1;
	private float turnSpeed = 2;

	void Update()
	{
		mover ();
		mover (turnSpeed);
	}

	void mover(){
		transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);
	}

	void mover(float turnSpeed){
		transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * turnSpeed);
	}

			void OnTriggerExit(Collider other){
		if (other.tag == "Target") {
			if (direction == 1) {
				direction = -1;
			} 
					else {
				direction = 1;
			}
		}
	}
}
