using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched4 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<tienda>().get[3] = true;
    }
}
