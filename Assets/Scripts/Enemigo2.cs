using UnityEngine;
using System.Collections;

public class Enemigo2 : MonoBehaviour
{

    // Use this for initialization

    // Vector3 movimiento;
    float y0;
    public float velocidad;
    MovimientoCharacterController playerScript;
    public bool pisado = false;

    void Awake()
    {
        y0 = transform.position.y;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoCharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    public void Muerto()
    {
        Destroy(gameObject);
    }

    private void Move()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,y0 + 3f * Mathf.Sin(Time.time * velocidad), gameObject.transform.position.z);
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
            }
            else
            {
                dir = 1;
            }
            playerScript.Herido(dir);
        }
    }
}


