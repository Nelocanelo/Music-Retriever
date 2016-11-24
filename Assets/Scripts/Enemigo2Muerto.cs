
using UnityEngine;
using System.Collections;

public class Enemigo2Muerto : MonoBehaviour
{

    Enemigo2 enemy;

    void Start()
    {
        enemy = GetComponentInParent<Enemigo2>();
    }
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enemy.Muerto();
        }
    }
}
