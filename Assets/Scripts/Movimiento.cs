using UnityEngine;
using System.Collections;

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

        /*
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            Vector3 movimiento = new Vector3(miRigidBody.position.x + 1, miRigidBody.position.y, miRigidBody.position.z);
            miRigidBody.MovePosition(movimiento);

        }else if(Input.GetAxis("Horizontal") < -0.1f)
        {
            Vector3 movimiento = new Vector3(miRigidBody.position.x - 1, miRigidBody.position.y, miRigidBody.position.z);
            miRigidBody.MovePosition(movimiento);
        }
        */
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
    }

    void OnTriggerExit(Collider otro)
    {
        if (otro.tag == "suelo")
        {
            enElSuelo = false;
        }
    }
}
