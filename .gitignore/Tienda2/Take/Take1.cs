using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take1 : MonoBehaviour {

    public static int compra;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (Score.score >= 0)
        {
            tienda2.number = 0;
            tienda2.changeBall = true;
        }
    }
}
