using UnityEngine;
using System.Collections;

public class EnemigoMuerto : MonoBehaviour {

    Enemigo enemy;
    
    void Start()
    {
        enemy = GetComponentInParent<Enemigo>();
    }
	// Use this for initialization
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enemy.pisado = true;
            //enemy.Muerto();
        }
    }
}
