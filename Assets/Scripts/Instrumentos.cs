﻿using UnityEngine;
using System.Collections;

public class Instrumentos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player") {
            Destroy(gameObject);
        }
    }
}
