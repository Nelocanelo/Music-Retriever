using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioManagerMio : MonoBehaviour {
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
        victoria = GameObject.FindGameObjectWithTag("Victoria");
        victoria.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(esbasso+ "," + esclarinete + "," + esfagot + "," + esflauta + "," + esoboe + "," + esviola + "," + esviolin + "," + esviolonchelo);
        if (esviolin) {
            violin.mute = false;
        }
        if (esviola)
        {
            viola.mute = false;
        }
        if (esviolonchelo)
        {
            violonchelo.mute = false;
        }
        if (esfagot)
        {
            violonchelo.mute = false;
        }
        if (esoboe)
        {
            oboe.mute = false;
        }
        if (esflauta)
        {
            flauta.mute = false;
        }
        if (esbasso)
        {
            basso.mute = false;
        }
        if (esclarinete)
        {
            clarinete.mute = false;
        }

        //El if del vencedor xD
        if (esbasso && esclarinete && esfagot && esflauta && esoboe && esviola && esviolin && esviolonchelo) {
            victoria.SetActive(true);
        }
    }
}
