using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched2 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<tienda>().get[1] = true;
    }
}
