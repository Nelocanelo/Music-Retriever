
using UnityEngine;
using System.Collections;

public class Enemigo2Muerto : MonoBehaviour
{

    Enemigo2 enemy;
    int puntos = 10;
    Collider colisionador;
    Rigidbody colliderPadre;

    void Start()
    {
        enemy = GetComponentInParent<Enemigo2>();
        colisionador = GetComponent<Collider>();
        colliderPadre = GetComponentInParent<Rigidbody>();
    }
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            enemy.pisado = true;
            AudioManagerMioTutorial.puntosTotales += puntos;
            AudioManagerMio.puntosTotales += puntos;
            colisionador.enabled = false;
            colliderPadre.detectCollisions = false;
            colliderPadre.useGravity = false;
            enemy.gameObject.transform.position = new Vector3(enemy.gameObject.transform.position.x, enemy.gameObject.transform.position.y, enemy.gameObject.transform.position.z + 1.5f);
            // enemy.Muerto();
        }
    }
}
