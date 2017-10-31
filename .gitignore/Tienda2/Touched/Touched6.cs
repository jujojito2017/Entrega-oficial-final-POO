using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched6 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<tienda>().get[5] = true;
    }
}
