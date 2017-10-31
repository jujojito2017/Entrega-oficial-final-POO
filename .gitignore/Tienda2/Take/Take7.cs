using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take7 : MonoBehaviour {

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
        if (Score.score >= 35)
        {
            if (compra > 0)
            {
                Score.score = Score.score - 35;
                tienda2.number = 6;
                tienda2.changeBall = true;
                compra--;
            }
        }

        else
        {
            if (compra == 0)
            {
                tienda2.number = 6;
                tienda2.changeBall = true;
            }
        }
    }
}
