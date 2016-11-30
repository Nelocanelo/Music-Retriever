using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovimientoCharacterController : MonoBehaviour {

    public float gravedad;
    public float velSalto;
    public float velocidad;

    private float velocidadCaida;
    private CharacterController controlador;
    [HideInInspector]public bool enSuelo;
    private RaycastHit hit;
    private bool herido;
    private float tiempoHerido;
    private Vector3 destHerido;

    private Text vidasText;
    int vidas = 3;

    // Use this for initialization
    void Start () {
        controlador = GetComponent<CharacterController>();
        vidasText = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Text>();
        vidasText.text = vidas.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        estaEnElSuelo();
        caer();
        saltar();
        movimientoLateral();

        if (herido)
        {
            transform.position = Vector3.Lerp(transform.position, destHerido, 0.1f);
            tiempoHerido += Time.deltaTime;
            if (tiempoHerido > 0.5f)
            {
                herido = false;
            }
        }
	}

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
    }

    void movimientoLateral() {
        float velx = Input.GetAxis("Horizontal");
        if (velx != 0) controlador.Move(new Vector3(velx, 0) * velocidad * Time.deltaTime);
    }

    void saltar() {
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo) {
            velocidadCaida = -velSalto; 
        }
    }

    void caer() {
        if (!enSuelo)
        {
            velocidadCaida += gravedad * Time.deltaTime;
        }
        else {
            if (velocidadCaida > 0) velocidadCaida = 0;
        }

        controlador.Move(new Vector3(0,-velocidadCaida) * Time.deltaTime);
    }

    void estaEnElSuelo() {
        if (Physics.Raycast(transform.position, -transform.up, out hit,controlador.height / 1.6f))//-transform.up es para que vaya para abajo, por el menos.
        {
            if (hit.collider.gameObject.tag == "suelo")
            {
                Debug.DrawLine(transform.position, new Vector3(transform.position.x, controlador.height / 1.6f, transform.position.z));
                enSuelo = true;
            }    
        }
        else {
            enSuelo = false;
            Debug.DrawLine(transform.position, new Vector3(transform.position.x, controlador.height / 1.6f, transform.position.z));
        }
    }

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "gameover")
        {
            gameOver();
        }
    }

    public void gameOver() {
        Debug.Log("Los enemigos han robado la navidad, por culpa de que eres lento y sordo");
        SceneManager.LoadScene(0);
    }

    public void Herido(int dir)
    {
        //controlador.Move(new Vector3(0.3f * dir, 0.2f) * 6);
        if (!herido)
        {
            Debug.Log("YAAAAAAAAAAAAAARRGGHGHGH");
            destHerido = new Vector3(transform.position.x + 3f * dir, transform.position.y + 2f);
            herido = true;
            tiempoHerido = 0;

            vidas--;
            vidasText.text = vidas.ToString();
        }
    }
}
