using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioManagerMio : MonoBehaviour {
    public List<GameObject> instrumentos;
    private int objetivo;

    public AudioSource violin;
    public AudioSource viola;
    public AudioSource violonchelo;
    public AudioSource fagot;
    public AudioSource flauta;
    public AudioSource oboe;
    public AudioSource basso;
    public AudioSource clarinete;

    public static bool esviolin = false;
    public static bool esviola = false;
    public static bool esviolonchelo = false;
    public static bool esfagot = false;
    public static bool esflauta = false;
    public static bool esoboe = false;
    public static bool esbasso = false;
    public static bool esclarinete = false;


    private GameObject victoria;

    // Use this for initialization
    void Start () {

        objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
        instrumentos.Remove(instrumentos[objetivo]);

        victoria = GameObject.FindGameObjectWithTag("Victoria");
        victoria.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(esbasso+ "," + esclarinete + "," + esfagot + "," + esflauta + "," + esoboe + "," + esviola + "," + esviolin + "," + esviolonchelo);
        if (esviolin) {
            violin.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            instrumentos.Remove(instrumentos[objetivo]);

        }
        if (esviola)
        {
            viola.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            instrumentos.Remove(instrumentos[objetivo]);

        }
        if (esviolonchelo)
        {
            violonchelo.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            instrumentos.Remove(instrumentos[objetivo]);
        }
        if (esfagot)
        {
            violonchelo.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            instrumentos.Remove(instrumentos[objetivo]);
        }
        if (esoboe)
        {
            oboe.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            instrumentos.Remove(instrumentos[objetivo]);
        }
        if (esflauta)
        {
            flauta.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            instrumentos.Remove(instrumentos[objetivo]);
        }
        if (esbasso)
        {
            basso.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            instrumentos.Remove(instrumentos[objetivo]);
        }
        if (esclarinete)
        {
            clarinete.mute = false;
            objetivo = UnityEngine.Random.Range(0, instrumentos.Count);
            //instrumentos.Remove(instrumentos[objetivo]);
        }

        //El if del vencedor xD
        if (esbasso && esclarinete && esfagot && esflauta && esoboe && esviola && esviolin && esviolonchelo) {
            victoria.SetActive(true);
        }
    }
}
