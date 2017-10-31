using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched1 : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        GetComponent<tienda>().get[0] = true;
    }
}
