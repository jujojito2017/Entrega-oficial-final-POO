using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int score;

    Text text;

	void Start () {
        text = GetComponent <Text> ();
        score = 0;
	}
	
	void Update () {
<<<<<<< HEAD
        scoreText();
    }

    void scoreText()
=======
        amount();
	}

    void amount()
>>>>>>> bd63bf2fb36b4b78546e503bfcb57a3fd0a09f88
    {
        text.text = "Score: " + score;
    }
}
