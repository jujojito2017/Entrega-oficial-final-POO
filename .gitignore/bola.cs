using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour {

    public float velocidad;
    public float altura;
    private int salto;

    private int scoreValue = 1;

    public AudioClip JumpClip;

    public AudioSource JumpSource;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        salto = 0;
    }

 
    void FixedUpdate()
    {
        mover();
        saltar();
        controlSalto();
    }

    void Update()
    {
        
    }

    void mover()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        Vector3 movimiento = new Vector3(x, 0.0f, y);

        if (Timer.timeLeft <= 0)
            {
              movimiento = Vector3.zero;
              rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, Time.deltaTime);
            }

            rb.AddForce(movimiento * velocidad);
    }

    void controlSalto()
    {
        if (salto >= 2)
        {
            salto = 1;
        }
    }

    void saltar()
    {
<<<<<<< HEAD
		if (Input.GetButtonDown("Fire3") && salto>=1 )
=======
        if (Input.GetButtonDown("Fire3") && salto>=1 )
>>>>>>> bd63bf2fb36b4b78546e503bfcb57a3fd0a09f88
        {
            JumpSource.Play();

            rb.velocity = new Vector3(0.0f, altura, 0.0f);

            salto = 0;

            if (Timer.timeLeft <= 0)
            {
                rb.velocity = Vector3.zero;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        salto++;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Score.score += scoreValue;
            ControladorModulos.control++;
        }
    }
}
