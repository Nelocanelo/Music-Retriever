using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {
    
    float x0;
    public float velocidad;
    MovimientoCharacterController playerScript;
    public bool pisado = false;
    private bool morirDespuesDeEfectos;
    private Animator animador;
    private GameObject particulasCorcheas;
    private GameObject particulasCorcheasOtraVer;
    private GameObject particulasLlaveSol;
    public bool muerte;
    public int puntos;

    void Awake()
    {
        x0 = transform.position.x;
        animador = GetComponent<Animator>();
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoCharacterController>();
        particulasCorcheas = gameObject.transform.GetChild(3).gameObject;
        particulasCorcheasOtraVer = gameObject.transform.GetChild(2).gameObject;
        particulasLlaveSol = gameObject.transform.GetChild(4).gameObject;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!pisado)
        {
            Move();
        }
        else {
           
            animador.SetTrigger("Pisado");
            particulasCorcheas.SetActive(true);
            particulasCorcheasOtraVer.SetActive(true);
            particulasLlaveSol.SetActive(true);
            if (particulasLlaveSol.GetComponent<ParticleSystem>().IsAlive() == false) {
                morirDespuesDeEfectos = true;
            }
        }
        if (pisado) {
            Muerto();
        }
    }

    public void Muerto()
    {
        if (morirDespuesDeEfectos) {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        if (velocidad > 0)
        {
            animador.SetBool("Correr",true);
        }
        else {
            animador.SetBool("Correr", false);
        }
        gameObject.transform.position = new Vector3(x0 + 3f * Mathf.Sin(velocidad * Time.time), gameObject.transform.position.y, gameObject.transform.position.z);
        if ((x0 + 3f * Mathf.Sin(velocidad * Time.time)) < x0 - 2.99f) {
            transform.rotation = Quaternion.AngleAxis(104,Vector3.up);
        } else if ((x0 + 3f * Mathf.Sin(velocidad * Time.time)) >= x0 + 2.99f) {
            transform.rotation = Quaternion.AngleAxis(280, Vector3.up);
        }
    }
    
    void OnTriggerEnter(Collider otro)
    {
        Debug.Log("Estoy dentro");
        if (otro.tag == "Player" && !pisado)
        {
            Debug.Log("tu vols morir?");
            int dir;
            if (transform.position.x - otro.transform.position.x > 0)
            {
                dir = -1;
            }else
            {
                dir = 1;
            }
            playerScript.Herido(dir);
        }
    }
}

