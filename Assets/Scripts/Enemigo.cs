using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    // Use this for initialization
   
    Vector3 movimiento;
    float distanciaMax = 1;
    float distanciaInicial;
    float distancia = 0;
    
    void Awake()
    {
        distanciaInicial = transform.position.x;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
    }
    public void Muerto()
    {
        Destroy(gameObject);
    }

    private void Move()
    {
        distancia = transform.position.x - distanciaInicial;
        if (distancia <= distanciaMax) {
            movimiento = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);

        } else if (distancia >= distanciaMax) {
            movimiento = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
             
        transform.position = movimiento;
    }
   
}

