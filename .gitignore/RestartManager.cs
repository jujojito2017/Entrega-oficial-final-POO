using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class RestartManager : MonoBehaviour {

    public Canvas canvas;

    public static bool die;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        die = false;
    }

    void Update()
    {
        if (die)
        {
            Pause();
        }
    }

    public void Pause()
    {
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        die = false;
    }

    public void Restart()
    {
        ControladorModulos.control = 40;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        canvas.enabled = !canvas.enabled;
    }
}
