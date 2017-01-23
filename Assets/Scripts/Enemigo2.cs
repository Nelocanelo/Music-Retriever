using UnityEngine;
using System.Collections;

public class Enemigo2 : MonoBehaviour
{

    // Use this for initialization

    // Vector3 movimiento;
    float y0;
    public float velocidad;
    MovimientoCharacterController playerScript;
    public bool pisado = false;
    private Animator animador;
    private GameObject particulasCorcheas;
    private GameObject particulasCorcheasOtraVer;
    private GameObject particulasLlaveSol;
    private bool morirDespuesDeEfectos;
    public bool muerte;

    void Awake()
    {
        y0 = transform.position.y;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoCharacterController>();
        animador = GetComponent<Animator>();
        particulasCorcheas = gameObject.transform.GetChild(3).gameObject;
        particulasCorcheasOtraVer = gameObject.transform.GetChild(2).gameObject;
        particulasLlaveSol = gameObject.transform.GetChild(4).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!pisado)
        {
            Move();
        }
        else {
            animador.SetTrigger("Muerte");
            particulasCorcheas.SetActive(true);
            particulasCorcheasOtraVer.SetActive(true);
            particulasLlaveSol.SetActive(true);
            if (particulasLlaveSol.GetComponent<ParticleSystem>().IsAlive() == false)
            {
                morirDespuesDeEfectos = true;
            }
        }
        if (pisado)
        {
            Muerto();
        }
    }
    public void Muerto()
    {
        if (morirDespuesDeEfectos)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,y0 + 3f * Mathf.Sin(Time.time * velocidad), gameObject.transform.position.z);
    }

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "Player" && !pisado)
        {
            Debug.Log("tu vols morir?");
            int dir;
            if (transform.position.x - otro.transform.position.x > 0)
            {
                dir = -1;
            }
            else
            {
                dir = 1;
            }
            playerScript.Herido(dir);
        }
    }
}


