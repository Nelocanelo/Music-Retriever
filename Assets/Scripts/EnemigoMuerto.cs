using UnityEngine;
using System.Collections;

public class EnemigoMuerto : MonoBehaviour {

    Enemigo enemy;
    Collider colisionador;
    Rigidbody colliderPadre;
    int puntos = 10;
    
    void Start()
    {
        enemy = GetComponentInParent<Enemigo>();
        colisionador = GetComponent<Collider>();
        colliderPadre = GetComponentInParent<Rigidbody>();
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
            enemy.gameObject.transform.position = new Vector3(enemy.gameObject.transform.position.x, enemy.gameObject.transform.position.y, enemy.gameObject.transform.position.z +1.5f);
            //enemy.Muerto();
        }
    }
}
