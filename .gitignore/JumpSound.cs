using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour {

    public AudioClip JumpClip;

    public AudioSource JumpSource;

	void Start () {
        JumpSource.clip = JumpClip;

    }
	
	void Update () {
<<<<<<< HEAD
        play();
	}

    void play()
=======
        jump();
	}

    void jump()
>>>>>>> bd63bf2fb36b4b78546e503bfcb57a3fd0a09f88
    {
        if (Input.GetKeyDown(KeyCode.Space))
            JumpSource.Play();
    }
}
