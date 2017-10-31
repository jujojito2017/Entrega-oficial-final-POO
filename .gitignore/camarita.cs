using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarita : MonoBehaviour {

    public GameObject jugador;
    private Vector3 posicion;


    void Start()
    {
        jugador = GameObject.FindWithTag("Jugador");

        posicion = transform.position - jugador.transform.position;
    }


    void LateUpdate()
    {
<<<<<<< HEAD
        follow();
    }

    void follow()
=======
        follower();
    }

    void follower()
>>>>>>> bd63bf2fb36b4b78546e503bfcb57a3fd0a09f88
    {
        jugador = GameObject.FindWithTag("Jugador");

        transform.position = jugador.transform.position + posicion;
    }
}
