using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisionController : MonoBehaviour {

    GameControllerFase2 controller;
    Text text;

    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameControllerFase2").GetComponent<GameControllerFase2>();
        text = GameObject.FindGameObjectWithTag("puntos").GetComponent<Text>();
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("hoygan");
        if (other.tag == "EnemigoFase2")
        {
            Destroy(other.gameObject, 0.0f);
            controller.score += 20;
            text.text = controller.score.ToString();
        }
    }


}
