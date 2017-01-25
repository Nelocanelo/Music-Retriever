using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioManagerMio : MonoBehaviour {
    public static bool resetear = false;

    public List<GameObject> instrumentos;
    public int objetivo;
    private Text textoInstrumento;
    string textoInicial;
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

        objetivo = Random.Range(0, instrumentos.Count);
        //instrumentos.Remove(instrumentos[objetivo]);
        textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
        //violin1 = true;

        victoria = GameObject.FindGameObjectWithTag("Victoria");
        victoria.SetActive(false);
        menuVictoria = GameObject.FindGameObjectWithTag("MenuVictoria");
        menuVictoria.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        // Debug.Log(esbasso+ "," + esclarinete + "," + esfagot + "," + esflauta + "," + esoboe + "," + esviola + "," + esviolin + "," + esviolonchelo);
        if (instrumentos.Count > 0)
        {
            if (esviolin)
            {
                violin.mute = false;
                if (!violin1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);

                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    violin1 = true;
                }
            }
            if (esviola)
            {
                viola.mute = false;
                if (!viola1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);

                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    viola1 = true;
                }
            }
            if (esviolonchelo)
            {
                violonchelo.mute = false;
                if (!violonchelo1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);
                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    violonchelo1 = true;
                }
            }
            if (esfagot)
            {
                fagot.mute = false;
                if (!fagot1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);

                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    fagot1 = true;
                }
            }
            if (esoboe)
            {
                oboe.mute = false;
                if (!oboe1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);

                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    oboe1 = true;
                }
            }
            if (esflauta)
            {
                flauta.mute = false;
                if (!flauta1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);

                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    flauta1 = true;
                }
            }
            if (esbasso)
            {
                basso.mute = false;
                if (!basso1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);

                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    basso1 = true;
                }
            }
            if (esclarinete)
            {
                clarinete.mute = false;
                if (!clarinete1)
                {
                    instrumentos.Remove(instrumentos[objetivo]);
                    objetivo = Random.Range(0, instrumentos.Count);
                    textoInstrumento.text = textoInicial + instrumentos[objetivo].name;
                    clarinete1 = true;
                }
            }
        }

        //El if del vencedor xD
        if (esbasso && esclarinete && esfagot && esflauta && esoboe && esviola && esviolin && esviolonchelo) {
            victoria.SetActive(true);
            menuVictoria.SetActive(true);
            
        }

        if (resetear) {
            resetearf();
        }
    }

    void resetearf() {
        objetivo = 0;
        textoInstrumento.text = textoInicial;
        resetear = false;

        esviolin = false;
        esviola = false;
        esviolonchelo = false;
        esfagot = false;
        esflauta = false;
        esoboe = false;
        esbasso = false;
        esclarinete = false;


        violin.mute = true;
        viola.mute = true;
        violonchelo.mute = true;
        fagot.mute = true;
        flauta.mute = true;
        oboe.mute = true;
        basso.mute = true;
        clarinete.mute = true;

        violin1 = false;
        viola1 = false;
        violonchelo1 = false;
        fagot1 = false;
        flauta1 = false;
        oboe1 = false;
        basso1 = false;
        clarinete1 = false;
    }
}
