using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParedController : MonoBehaviour {

    [System.Serializable]
    public class Boundary
    {
        public float yMin = 7.848f;
        public float yMax = 8.951f;
    }


    float speed = 2;
    Rigidbody rb;
    Boundary boundary;
    GameControllerFase2 controller;
    Text text;

    void Start () {
        rb = GetComponent<Rigidbody>();
        controller = GameObject.FindGameObjectWithTag("GameControllerFase2").GetComponent<GameControllerFase2>();
        text = GameObject.FindGameObjectWithTag("puntos").GetComponent<Text>();
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0.0f , moveVertical,0.0f);
        rb.velocity = movement * speed;
        rb.position = new Vector3(0.0f,Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax),0.0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EnemigoFase2")
        {
            Destroy(other.gameObject,0.0f);
            controller.score += 20;
            text.text = controller.score.ToString();

        }
    }

}
