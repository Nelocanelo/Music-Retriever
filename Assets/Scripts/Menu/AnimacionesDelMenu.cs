using UnityEngine;
using System.Collections;

public class AnimacionesDelMenu : MonoBehaviour {
    private GameObject enemigo;
    private Animator animadorEnemigo;
    private GameObject perro;
    private Animator animadorPerro;
    private GameObject movedorMenu;
    private GameObject particulas;

    //Musiquilla:
    public AudioSource musica1;
    public AudioSource musica2;
    public AudioSource ladrarSonido;
    //public AudioSource pasos;
    private bool activarMusica2 = true;
    private bool activarLadrido = true;


    //Booleanos que controlan la animación:
    private bool encontrarMusica = true;//Enemigo camina hacia las notas
    private bool coger;//El enemigo se rie al ver las notas
    private bool ladrido;//El perro ladra desde fuera de plano
    private bool perroCorriendo;//Perro persigue al enemigo
    private bool enemigoCorriendo;//Perro persigue al enemigo
    private bool menuBajando;//Baja el menu mientras el perro persigue al enemigo y desaparecen
    private bool destruirlos;//Porque han salido del plano de la camara.
    private bool pararChiringuito;
    private bool interruptor;
    private bool todoDestruido;
	
	void Start () {
        movedorMenu = GameObject.FindGameObjectWithTag("MovedorMenu");
        enemigo = GameObject.FindGameObjectWithTag("Enemy");
        perro = GameObject.FindGameObjectWithTag("Player");
        particulas = GameObject.FindGameObjectWithTag("Particulas");
        animadorEnemigo = enemigo.GetComponent<Animator>();
        animadorPerro = perro.GetComponent<Animator>();
        musica1.Play();
    }

    IEnumerator encontrarMusicaf() {
        animadorEnemigo.SetBool("Correr",true);
        enemigo.transform.position = new Vector3(enemigo.transform.position.x+0.04f, enemigo.transform.position.y, enemigo.transform.position.z);
        yield return new WaitForSeconds(5f);
        StopCoroutine("encontrarMusicaf");
        encontrarMusica = false;
        animadorEnemigo.SetBool("Correr", false);
        coger = true;
    }

    IEnumerator cogerf()
    {
        animadorEnemigo.SetBool("Coger", true);
        yield return new WaitForSeconds(0.5f);
        particulas.SetActive(false);
        StopCoroutine("cogerf");
        coger = false;
        animadorEnemigo.SetBool("Coger", false);
        ladrido = true;
    }

    IEnumerator ladridof() {
        yield return new WaitForSeconds(1f);
        musica1.Stop();
        if (activarLadrido)
        {
            ladrarSonido.Play();
        }
        StopCoroutine("ladridof");
        ladrido = false;
        perroCorriendo = true;
    }

    IEnumerator perroCorriendof()
    {
        animadorPerro.SetBool("Andando", true);
        perro.transform.position = new Vector3(perro.transform.position.x + 0.05f, perro.transform.position.y, perro.transform.position.z);
        yield return new WaitForSeconds(4f);
        if (activarMusica2)
        {
            musica2.Play();
            activarMusica2 = false;
        }
        animadorPerro.SetBool("Andando", true);
        perro.transform.position = new Vector3(perro.transform.position.x + 0.03f, perro.transform.position.y, perro.transform.position.z);
        enemigoCorriendo = true;
    }

    IEnumerator enemigoCorriendof() {
        if (activarLadrido)
        {
            ladrarSonido.Play();
            activarLadrido = false;
        }
        animadorEnemigo.SetBool("Correr", true);
        enemigo.transform.position = new Vector3(enemigo.transform.position.x + 0.04f, enemigo.transform.position.y, enemigo.transform.position.z);
        yield return new WaitForSeconds(1);
        menuBajando = true;
        animadorEnemigo.SetBool("Correr", true);
        enemigo.transform.position = new Vector3(enemigo.transform.position.x + 0.04f, enemigo.transform.position.y, enemigo.transform.position.z);

    }

    void bajarMenu() {
        // movedorMenu.GetComponent<RectTransform>().localPosition = new Vector3(movedorMenu.transform.position.x, perro.transform.position.y - 0.001f, perro.transform.position.z); ;
        if (movedorMenu.transform.localPosition.y >= 0)
        {
            movedorMenu.transform.position = new Vector3(movedorMenu.transform.position.x, movedorMenu.transform.position.y - 1f, movedorMenu.transform.position.z);
        }
        else
        {
            StopAllCoroutines();
            menuBajando = false;
            destruirlos = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetMouseButtonDown(0) && !interruptor && !todoDestruido || Input.GetKeyDown(KeyCode.Space) && !interruptor && !todoDestruido) {
            pararChiringuito = true;
        }

        if (encontrarMusica && ! pararChiringuito )
        {
            StartCoroutine("encontrarMusicaf");
        }
        else if (coger && !pararChiringuito ) {
            StartCoroutine("cogerf");
        } else if (ladrido && !pararChiringuito ) {
            StartCoroutine("ladridof");
        } else if (perroCorriendo && !pararChiringuito ) {
            StartCoroutine("perroCorriendof");
        }

        if (enemigoCorriendo && !pararChiringuito) {
            StartCoroutine("enemigoCorriendof");
        }

        if (menuBajando && !pararChiringuito) {
            bajarMenu();
        }

        if (destruirlos && !pararChiringuito) {
            StopAllCoroutines();
            perroCorriendo = false;
            enemigoCorriendo = false;
            //Destroy(animadorEnemigo);
            //Destroy(animadorPerro);
            perro.SetActive(false);
            //Destroy(perro);
            //Destroy(enemigo);
            enemigo.SetActive(false);
            todoDestruido = true;
            pararChiringuito = true;
        }

        if (pararChiringuito) {
            StopAllCoroutines();
            interruptor = true;
            perroCorriendo = false;
            enemigoCorriendo = false;
           // Destroy(animadorEnemigo);
           // Destroy(animadorPerro);
            musica1.Stop();
            musica2.Play();
            //Destroy(perro);
            //Destroy(enemigo);
            enemigo.SetActive(false);
            perro.SetActive(false);
            particulas.SetActive(false);
            //Destroy(particulas);
            movedorMenu.transform.localPosition = new Vector3(movedorMenu.transform.localPosition.x, 0, movedorMenu.transform.localPosition.z);
            pararChiringuito = false;
        }
	}
}
