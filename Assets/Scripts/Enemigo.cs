using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {
    
    float x0;
    public float velocidad;
    MovimientoCharacterController playerScript;
    public bool pisado = false;

    void Awake()
    {
        x0 = transform.position.x;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoCharacterController>();
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
    
    void OnTriggerEnter(Collider otro)
    {
        if (otro.tag == "Player" && !pisado)
        {
            Debug.Log("tu vols morir?");
            int dir;
            if (transform.position.x - otro.transform.position.x > 0)
            {
                dir = -1;
            }else
            {
                dir = 1;
            }
            playerScript.Herido(dir);
        }
    }
}

