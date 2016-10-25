using UnityEngine;
using System.Collections;

public class MovimientoRB : MonoBehaviour {

    private float velocidad;
    Rigidbody miRB;

	// Use this for initialization
	void Start () {

        miRB = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        velocidad = Input.GetAxis("Horizontal") * 10;
        Debug.Log(velocidad);

	}

    void FixedUpdate()
    {
        miRB.AddForce(new Vector3(velocidad, 0, 0));
    }
}
