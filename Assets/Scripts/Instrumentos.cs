using UnityEngine;
using System.Collections;

public class Instrumentos : MonoBehaviour {
    //private AudioManagerMio audioManager;
	// Use this for initialization
	void Start () {
      //  audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManagerMio>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player") {
            if (gameObject.tag == "Violines") {
                AudioManagerMio.esviolin = true;
            } else if (gameObject.tag == "Violines") {
                AudioManagerMio.esviolin = true;
            }
            else if (gameObject.tag == "Viola")
            {
                AudioManagerMio.esviola = true;
            }
            else if (gameObject.tag == "Violonchelo")
            {
                AudioManagerMio.esviolonchelo = true;
            }
            else if (gameObject.tag == "Fagot")
            {
                AudioManagerMio.esfagot = true;
            }
            else if (gameObject.tag == "Oboe")
            {
                AudioManagerMio.esoboe = true;
            }
            else if (gameObject.tag == "Flauta")
            {
                AudioManagerMio.esflauta = true;
            }
            else if (gameObject.tag == "Basso")
            {
                AudioManagerMio.esbasso = true;
            }
            else if (gameObject.tag == "Clarinete")
            {
                AudioManagerMio.esclarinete = true;
            }

            Destroy(gameObject);
        }
    }
}
