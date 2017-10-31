using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    [SerializeField] public string loadLevel;

<<<<<<< HEAD
    public void Click()
=======
    public void OnMouseDown()
>>>>>>> bd63bf2fb36b4b78546e503bfcb57a3fd0a09f88
    {
        SceneManager.LoadScene (loadLevel) ;
    }
}
