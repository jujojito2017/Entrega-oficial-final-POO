using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructor : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador")
        {
            RestartManager.die = true;
            Score.score = 0;
        }
    }
}
