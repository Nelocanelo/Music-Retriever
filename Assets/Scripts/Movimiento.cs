using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

    private Rigidbody miRigidBody;

	// Use this for initialization
	void Start() {

        miRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update() {

        Debug.Log("Input: " + (Input.GetAxis("Horizontal")));

        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            Vector3 movimiento = new Vector3(miRigidBody.position.x + 1, miRigidBody.position.y, miRigidBody.position.z);
            miRigidBody.MovePosition(movimiento);

        }else if(Input.GetAxis("Horizontal") < -0.1f)
        {
            Vector3 movimiento = new Vector3(miRigidBody.position.x - 1, miRigidBody.position.y, miRigidBody.position.z);
            miRigidBody.MovePosition(movimiento);
        }
	}
}
