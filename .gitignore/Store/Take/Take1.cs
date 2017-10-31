using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take1 : MonoBehaviour {

    public static int compra;

    void Start()
    {
        compra = 1;
    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (Score.score >= 0)
        {
            if (compra > 0)
            {
                tienda.number = 0;
                tienda.changeBall = true;
                compra--;
            }
        }

        else
        {
            if (compra == 0)
            {
                tienda.number = 0;
                tienda.changeBall = true;
            }
        }
    }
}
