using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoControllerFase2 : MonoBehaviour {

    GameControllerFase2 controller;
    float speed;


	// Use this for initialization
	void Start () {
        controller = GameObject.FindGameObjectWithTag("GameControllerFase2").GetComponent<GameControllerFase2>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        speed = controller.speed;
        transform.position = new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);
	}
}
