using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    // Use this for initialization
   
   // Vector3 movimiento;
    float x0;
    public float velocidad = 2f;

    void Awake()
    {
        x0 = transform.position.x;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
    }
    public void Muerto()
    {
        Destroy(gameObject);
    }

    private void Move()
    {

        gameObject.transform.position = new Vector3(x0 + 3f * Mathf.Sin(velocidad * Time.time), gameObject.transform.position.y, gameObject.transform.position.z);
       
    }
   
}

