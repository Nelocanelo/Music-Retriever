using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    // Use this for initialization
   
   // Vector3 movimiento;
    float x0;

    void Awake()
    {
        x0 = transform.position.x;
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

        gameObject.transform.position = new Vector3(x0 + 3f * Mathf.Sin(2f * Time.time), gameObject.transform.position.y, gameObject.transform.position.z);
        /*distancia = transform.position.x - distanciaInicial;
        distancia = Mathf.Abs(distancia);
        Debug.Log(distancia);
        if (distancia <= distanciaMax) {
            movimiento = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);

        } else if (distancia >= distanciaMax) {
            movimiento = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
             
        transform.position = movimiento;*/
    }
   
}

