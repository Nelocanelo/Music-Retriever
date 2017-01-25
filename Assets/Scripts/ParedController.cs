using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParedController : MonoBehaviour {

    [System.Serializable]
    public class Boundary
    {
        public float yMin = 8.122f + 0.11f;
        public float yMax = 9.311f - 0.154f;
    }


    float speed = 2;
    Rigidbody rb;
    Boundary boundary;
    GameControllerFase2 controller;
    Text text;

    private GameObject menuPausa;
    public static bool pausaActivada = false;

    void Start () {
        //rb = GetComponent<Rigidbody>();
        controller = GameObject.FindGameObjectWithTag("GameControllerFase2").GetComponent<GameControllerFase2>();
        text = GameObject.FindGameObjectWithTag("puntos").GetComponent<Text>();
        boundary = new Boundary();
        menuPausa = GameObject.FindGameObjectWithTag("Pausa");
        menuPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausaActivada)
            {
                menuPausa.SetActive(true);
                pausaActivada = true;
                Time.timeScale = 0;
            }
            else
            {
                menuPausa.SetActive(false);
                pausaActivada = false;
                Time.timeScale = 1;
            }
        }
    }

    void FixedUpdate()
    {

        float moveVertical = Input.GetAxis("Vertical");
        transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y + moveVertical * Time.deltaTime * 2, boundary.yMin, boundary.yMax),transform.position.z);
    }

    /*void OnTriggerEnter(Collider other)
    {
        Debug.Log("hoygan");
        if(other.tag == "EnemigoFase2")
        {
            Destroy(other.gameObject,0.0f);
            controller.score += 20;
            text.text = controller.score.ToString();
        }
    }*/

}
