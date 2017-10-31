using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	void Start () {
		
	}
	
	void Update ()
    {
<<<<<<< HEAD
        rotateUp();
    }

    void rotateUp()
=======
        rotation();
    }

    void rotation()
>>>>>>> bd63bf2fb36b4b78546e503bfcb57a3fd0a09f88
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}
