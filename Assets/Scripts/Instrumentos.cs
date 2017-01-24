using UnityEngine;
using System.Collections;

public class Instrumentos : MonoBehaviour {
    //private AudioManagerMio audioManager;
    // Use this for initialization
    private AudioManagerMio instrumentos;
	void Start () {
        //  audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManagerMio>();
        instrumentos = GameObject.FindObjectOfType<AudioManagerMio>().GetComponent<AudioManagerMio>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player" && instrumentos.instrumentos[instrumentos.objetivo].tag == gameObject.tag) {
            if (gameObject.tag == "Violines") {
                AudioManagerMio.esviolin = true;
                Destroy(gameObject);
            } else if (gameObject.tag == "Violines") {
                AudioManagerMio.esviolin = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Viola")
            {
                AudioManagerMio.esviola = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Violonchelo")
            {
                AudioManagerMio.esviolonchelo = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Fagot")
            {
                AudioManagerMio.esfagot = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Oboe")
            {
                AudioManagerMio.esoboe = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Flauta")
            {
                AudioManagerMio.esflauta = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Basso")
            {
                AudioManagerMio.esbasso = true;
                Destroy(gameObject);
            }
            else if (gameObject.tag == "Clarinete")
            {
                AudioManagerMio.esclarinete = true;
                Destroy(gameObject);
            }

            
        }
    }
}
