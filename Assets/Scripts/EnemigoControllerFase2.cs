using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoControllerFase2 : MonoBehaviour {

    GameControllerFase2 controller;
    public float speed = 0.5f;


	// Use this for initialization
	void Start () {
        controller = GameObject.FindGameObjectWithTag("GameControllerFase2").GetComponent<GameControllerFase2>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GameControllerFase2")
        {
            Destroy(gameObject, 0.0f);
            controller.life -= 5;
        }
    }

}
