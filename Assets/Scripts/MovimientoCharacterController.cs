using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MovimientoCharacterController : MonoBehaviour {

    public float gravedad;
    public float velSalto;
    public float velocidad;

    private float velocidadCaida;
    private CharacterController controlador;
    [HideInInspector]public bool enSuelo;
    private RaycastHit hit;


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
            SceneManager.LoadScene(0);
        }
    }
}
