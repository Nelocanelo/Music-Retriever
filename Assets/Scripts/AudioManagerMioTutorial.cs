using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioManagerMioTutorial: MonoBehaviour {
    public static Text textoInstrumento;
    string textoInicial;
    [HideInInspector]public string nombreInstrumento;
    private GameObject textoInstrumentoObj;
    private GameObject menuVictoria;

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

    private bool violin1;
    private bool viola1;
    private bool violonchelo1;
    private bool fagot1;
    private bool flauta1;
    private bool oboe1;
    private bool basso1;
    private bool clarinete1;



    private GameObject victoria;

    // Use this for initialization
    void Start () {

        textoInstrumento = GameObject.FindGameObjectWithTag("TextoInstrumento").GetComponent<Text>();
        textoInstrumentoObj = GameObject.FindGameObjectWithTag("TextoInstrumento");
        textoInicial = textoInstrumento.text;

        textoInstrumento.text = textoInicial + "Flauta";
        nombreInstrumento = "Flauta";

        victoria = GameObject.FindGameObjectWithTag("Victoria");
        victoria.SetActive(false);
        menuVictoria = GameObject.FindGameObjectWithTag("MenuVictoria");
        menuVictoria.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(esbasso+ "," + esclarinete + "," + esfagot + "," + esflauta + "," + esoboe + "," + esviola + "," + esviolin + "," + esviolonchelo);
        if (esviolin) {
            violin.mute = false;
            if (!violin1) {
                textoInstrumento.text = textoInicial + "Clarinete";
                nombreInstrumento = "Clarinete";
                violin1 = true;
            }
        }
        if (esviola)
        {
            viola.mute = false;
            if (!viola1)
            {
                viola1 = true;
                textoInstrumento.text = "";
            }
        }
        if (esviolonchelo)
        {
            violonchelo.mute = false;
            Debug.Log("Violonchelando");
            if (!violonchelo1)
            {
                textoInstrumento.text = textoInicial + "Viola";
                nombreInstrumento = "Viola";
                violonchelo1 = true;
            }
        }
        if (esfagot)
        {
            fagot.mute = false;
            if (!fagot1)
            {
                textoInstrumento.text = textoInicial + "Basso";
                nombreInstrumento = "Basso";
                fagot1 = true;
            }
        }
        if (esoboe)
        {
            oboe.mute = false;
            if (!oboe1)
            {
                textoInstrumento.text = textoInicial + "Violonchelo";
                nombreInstrumento = "Violonchelo";
                oboe1 = true;
            }
        }
        if (esflauta)
        {
            flauta.mute = false;
            if (!flauta1)
            {
                textoInstrumento.text = textoInicial + "Violin";
                nombreInstrumento = "Violin";
                flauta1 = true;
            }
        }
        if (esbasso)
        {
            basso.mute = false;
            if (!basso1)
            {
                textoInstrumento.text = textoInicial + "Oboe";
                nombreInstrumento = "Oboe";
                basso1 = true;
            }
        }
        if (esclarinete)
        {
            clarinete.mute = false;
            if (!clarinete1)
            {
                textoInstrumento.text = textoInicial + "Fagot";
                nombreInstrumento = "Fagot";
                clarinete1 = true;
            }
        }

        //El if del vencedor xD
        if (esbasso && esclarinete && esfagot && esflauta && esoboe && esviola && esviolin && esviolonchelo) {
            victoria.SetActive(true);
            menuVictoria.SetActive(true);
           
        }
    }
}
