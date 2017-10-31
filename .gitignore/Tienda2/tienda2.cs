using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tienda2 : MonoBehaviour {

    public bool[] get = new bool[8];

    public static int number;
    public static bool changeBall;

    public GameObject ball;

    public GameObject[] up;
    public GameObject[] empty;
    public GameObject[] costText;

    public Material[] material;
    Renderer rend;


    void Start()
    {
        number = 0;
        changeBall = true;
        rend = ball.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }


    void Update()
    {
        changer();

    }

    public void changer()
    {
        if (changeBall)
        {
            int i = 0;

            rend.sharedMaterial = material[number];

            GameObject[] pick = GameObject.FindGameObjectsWithTag("Pick Up");

            Destroy(GameObject.FindWithTag("Jugador"));

            foreach (GameObject collectible in pick)
            {
                GameObject.Destroy(collectible);
            }

            Instantiate(ball, transform.position, transform.rotation);

            while (i < 7)
            {
                if (get[i] == false)
                {
                    Instantiate(up[number], empty[i].transform);
                    i++;
                }
            }

            Destroy(costText[number]);

            changeBall = false;
        }
    }
}
