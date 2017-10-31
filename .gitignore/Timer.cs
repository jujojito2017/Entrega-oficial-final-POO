using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public static int timeLeft = 300;
    public Text countdownText;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine("LoseTime");
    }

    void Update()
    {
        timerText();
    }

    void timerText()
    {
        text.text = ("Time: " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            text.text = "Times Up!";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}

