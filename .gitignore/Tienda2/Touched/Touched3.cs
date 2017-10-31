using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched3 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<tienda>().get[2] = true;
    }
}
