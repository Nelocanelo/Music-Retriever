using UnityEngine;
using System.Collections;

public class InstrumentosTutorial : MonoBehaviour {
    //private AudioManagerMio audioManager;
    // Use this for initialization
    int puntos = 50;
    private AudioManagerMioTutorial instrumentos;
	void Start () {
        //  audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManagerMio>();
        instrumentos = GameObject.FindObjectOfType<AudioManagerMioTutorial>().GetComponent<AudioManagerMioTutorial>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player") {
            if (gameObject.tag == "Violines" && instrumentos.nombreInstrumento == "Violin") {
                AudioManagerMioTutorial.esviolin = true;
                Destroy(gameObject);
            } else if (gameObject.tag == "Violines" && instrumentos.nombreInstrumento == "Violin") {
                AudioManagerMioTutorial.esviolin = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Viola" && instrumentos.nombreInstrumento == "Viola")
            {
                AudioManagerMioTutorial.esviola = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Violonchelo" && instrumentos.nombreInstrumento == "Violonchelo")
            {
                AudioManagerMioTutorial.esviolonchelo = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Fagot" && instrumentos.nombreInstrumento == "Fagot")
            {
                AudioManagerMioTutorial.esfagot = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Oboe" && instrumentos.nombreInstrumento == "Oboe")
            {
                AudioManagerMioTutorial.esoboe = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Flauta" && instrumentos.nombreInstrumento == "Flauta")
            {
                AudioManagerMioTutorial.esflauta = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Basso" && instrumentos.nombreInstrumento == "Basso")
            {
                AudioManagerMioTutorial.esbasso = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Clarinete" && instrumentos.nombreInstrumento == "Clarinete")
            {
                AudioManagerMioTutorial.esclarinete = true;
                Destroy(gameObject);
            }
            AudioManagerMioTutorial.puntosTotales += puntos;

        }
    }
}
