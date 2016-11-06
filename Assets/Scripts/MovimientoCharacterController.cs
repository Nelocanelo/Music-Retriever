using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MovimientoCharacterController : MonoBehaviour {

    public float gravedad;
    public float velSalto;
    public float velocidad;

    private float velocidadCaida;
    private CharacterController controlador;
    private bool enSuelo;

    
	// Use this for initialization
	void Start () {
        controlador = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        estaEnElSuelo();
        caer();
        saltar();
        movimientoLateral();
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
        if (Physics.Raycast(transform.position, -transform.up, controlador.height / 1.8f))//-transform.up es para que vaya para abajo, por el menos.
        {
            enSuelo = true;
        }
        else {
            enSuelo = false;
        }
    }

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "gameover")
        {
            SceneManager.LoadScene(0);
        }
    }
}
