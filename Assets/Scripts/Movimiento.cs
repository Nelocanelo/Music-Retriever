using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour {

    private Rigidbody miRigidBody;

    public float velocidad;
    public float fuerzaSalto;

    private bool enElAire;
    public bool enElSuelo;
    private bool saltoListo;

    // Use this for initialization
    void Start() {

        miRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update() {

        if (Input.GetAxis("Horizontal") != 0f)
        {
            Vector3 movimiento = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            movimiento *= velocidad;
            transform.Translate(movimiento * Time.deltaTime);
        }
	}

    void FixedUpdate()
    {
        if (enElSuelo && Input.GetKeyDown("space"))
        {
            miRigidBody.AddForce(new Vector3(0, fuerzaSalto, 0));
        }
    }

    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "suelo")
        {
            enElSuelo = true;
        }

        if (otro.tag == "gameover")
        {
            SceneManager.LoadScene(0);
        }
    }

    void OnTriggerExit(Collider otro)
    {
        if (otro.tag == "suelo")
        {
            enElSuelo = false;
        }
    }
}
