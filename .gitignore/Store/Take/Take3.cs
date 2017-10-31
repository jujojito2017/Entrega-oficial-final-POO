using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take3 : MonoBehaviour {

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
        if (Score.score >= 20)
        {
            if (compra > 0)
            {
                Score.score = Score.score - 20;
                tienda.number = 2;
                tienda.changeBall = true;
                compra--;
            }
        }

        else
        {
            if (compra == 0)
            {
                tienda.number = 2;
                tienda.changeBall = true;
            }
        }
    }
}
