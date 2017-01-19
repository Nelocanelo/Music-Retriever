using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedController : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
        if (Input.GetAxis("Vertical"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 5 * Time.deltaTime,transform.position.z);
        }
	}
}
