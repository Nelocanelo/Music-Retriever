using UnityEngine;
using System.Collections;

public class Enemigo2 : MonoBehaviour
{

    // Use this for initialization

    // Vector3 movimiento;
    float y0;
    public float velocidad;

    void Awake()
    {
        y0 = transform.position.y;
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

}


