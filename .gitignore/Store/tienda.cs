using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class tienda : MonoBehaviour {

    public static int number;
    public static bool changeBall;

    public GameObject[] ball;
    public GameObject[] up;
    public GameObject[] costText;

	public GameObject aro;
	public GameObject emptyAro;

    void Start()
    {
        number = 0;
        changeBall = true;
    }


    void Update()
    {
        changer();

    }

    public void changer()
    {
        if (changeBall)
        {
            Destroy(GameObject.FindWithTag("Jugador")); 

            GameObject[] picks = GameObject.FindGameObjectsWithTag("Pick Up");

            foreach (GameObject ups in picks)
            {
                GameObject.Destroy(ups);
            }

            Instantiate(ball[number], transform.position, transform.rotation);

            GameObject[] coin = GameObject.FindGameObjectsWithTag("Coin");

            foreach (GameObject bit in coin)
            {
                Instantiate(up[number], bit.transform.position, bit.transform.rotation);
            }

			Destroy(GameObject.FindWithTag("Aro")); 

			Instantiate(aro, emptyAro.transform.position, emptyAro.transform.rotation);

            Destroy(costText[number]);

            changeBall = false;
        }
    }
}
