using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosDeLasBolas : MonoBehaviour {
    private GameObject textoPuntos;
    private GameObject instrumento;

	// Use this for initialization
	void Start () {
		textoPuntos = gameObject.transform.GetChild(1).gameObject;
        instrumento = gameObject.transform.GetChild(0).gameObject;
        textoPuntos.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (instrumento == null)
        {
            textoPuntos.SetActive(true);
            StartCoroutine("movimientoPuntos");
        }
    }

    IEnumerator movimientoPuntos()
    {
        textoPuntos.transform.position = new Vector3(textoPuntos.transform.position.x, textoPuntos.transform.position.y + 0.015f, textoPuntos.transform.position.z);
        yield return new WaitForSeconds(2.5f);
        textoPuntos.SetActive(false);
        Destroy(gameObject);
    }
}
