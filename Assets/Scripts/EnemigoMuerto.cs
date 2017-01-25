using UnityEngine;
using System.Collections;

public class EnemigoMuerto : MonoBehaviour {

    Enemigo enemy;
    Collider colisionador;
    Rigidbody colliderPadre;
    GameObject puntosFlotantes;
    int puntos = 10;
    
    void Start()
    {
        enemy = GetComponentInParent<Enemigo>();
        colisionador = GetComponent<Collider>();
        colliderPadre = GetComponentInParent<Rigidbody>();
        puntosFlotantes = gameObject.transform.GetChild(0).gameObject;
        puntosFlotantes.SetActive(false);
    }
	// Use this for initialization
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enemy.pisado = true;
            AudioManagerMioTutorial.puntosTotales += puntos;
            AudioManagerMio.puntosTotales += puntos;
            colisionador.enabled = false;
            colliderPadre.detectCollisions = false;
            colliderPadre.useGravity = false;
            puntosFlotantes.SetActive(true);
            enemy.gameObject.transform.position = new Vector3(enemy.gameObject.transform.position.x, enemy.gameObject.transform.position.y, enemy.gameObject.transform.position.z +1.5f);
            //enemy.Muerto();
        }
    }

    IEnumerator movimientoPuntos() {
        puntosFlotantes.transform.position = new Vector3(puntosFlotantes.transform.position.x, puntosFlotantes.transform.position.y + 0.015f, puntosFlotantes.transform.position.z);
        yield return new WaitForSeconds(2.5f);
        puntosFlotantes.SetActive(false);
    }

    void Update() {
        puntosFlotantes.transform.rotation = Quaternion.AngleAxis(-9.256001f, Vector3.up);
        if (enemy.pisado)
        {
            StartCoroutine("movimientoPuntos");
        }
    }
}
