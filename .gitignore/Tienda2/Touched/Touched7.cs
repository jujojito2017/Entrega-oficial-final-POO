using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched7 : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<tienda>().get[6] = true;
    }
}
