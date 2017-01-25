using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoControllerFase2 : MonoBehaviour {

    GameControllerFase2 controller;
    public int tipo;
    public float speed;
    Text vidas;
    Text text;


	// Use this for initialization
	void Start () {
        controller = GameObject.FindGameObjectWithTag("GameControllerFase2").GetComponent<GameControllerFase2>();
        vidas = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Text>();
        text = GameObject.FindGameObjectWithTag("puntos").GetComponent<Text>();
        switch (tipo)
        {
            case 1:
                speed = 1f;
                break;
            case 2:
                speed = 0.9f;
                break;
            case 3:
                speed = 0.7f;
                break;
            case 4:
                speed = 0.3f;
                break;
        }
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
            vidas.text = controller.life.ToString();
        }

        if (other.tag == "ParedFase2")
        {
            Debug.Log("eh");
            Destroy(gameObject, 0.0f);
            controller.score += 20;
            text.text = controller.score.ToString();
        }
    }

}
