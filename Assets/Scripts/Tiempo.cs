using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Tiempo : MonoBehaviour {
    public Text texto;
    private MovimientoCharacterController player;
    int tiempo = 600;
	// Use this for initialization
	void Start () {
        texto.text = tiempo.ToString();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoCharacterController>();
        InvokeRepeating("contador", 1.0f, 1.0f);

	}

    void contador() {
        tiempo--;
        if (tiempo >= 0)
        {
            texto.text = tiempo.ToString();
        }
        else {
            texto.text = "0";
        }
    }

    void Update() {
        if (tiempo <= 0) {
            player.gameOver();
        }
    }
}
