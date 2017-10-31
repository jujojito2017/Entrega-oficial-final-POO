using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorModulos : MonoBehaviour {

    public static bool bang;
    public static int control;

    public GameObject[] empty;
    public GameObject[] module;

    void Start () {
        bang = true;
        control = 0;
    }

	void Update () {
                restart();
        begining();
    }

    void begining()
    {
        if (bang)
        {
            GameObject[] mod = GameObject.FindGameObjectsWithTag("Module");

            foreach (GameObject md in mod)
            {
                GameObject.Destroy(md);
            }

            foreach (GameObject space in empty)
            {
                int number = Random.Range(0, module.Length);
                Instantiate(module[number], space.transform.position, module[number].transform.rotation);
            }

            bang = false;
        }
    }

    void restart()
    {
        if(control >= 40)
        {
            bang = true;
            tienda.changeBall = true;
            Timer.timeLeft = 300;
            control = 0;
        }
    }
}
