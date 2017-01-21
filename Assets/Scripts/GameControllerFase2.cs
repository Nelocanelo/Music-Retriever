using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerFase2 : MonoBehaviour {

    public float life;
    public int score;
    GameObject[] spawners;
    public GameObject prefab;

/*	void Start ()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        InvokeRepeating("SpawnEnemyType1", 11.0f, 1f);
        InvokeRepeating("SpawnEnemyType3", 1.0f, 8f);
        InvokeRepeating("SpawnEnemyType4", 4.0f, 3f);
        InvokeRepeating("SpawnEnemyType2", 3.0f, 2f);
    }
	
	
	void Update ()
    {
        
	}

    void SpawnEnemyType1()
    {
        GameObject copy;
        int random = Mathf.Abs(Random.Range(0, 4));
        copy = Instantiate(prefab, spawners[random].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        copy.GetComponent<EnemigoControllerFase2>().speed = 0.1f;
    }

    void SpawnEnemyType2()
    {
        int random = Mathf.Abs(Random.Range(0, 4));
        GameObject copy = Instantiate(prefab, spawners[random].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        copy.GetComponent<EnemigoControllerFase2>().speed = 0.3f;
        copy = Instantiate(prefab, copy.transform.position + new Vector3(0.3f, 0, 0), Quaternion.Euler(0.0f, 0.0f, 0.0f));
        copy.GetComponent<EnemigoControllerFase2>().speed = 0.3f;
        copy = Instantiate(prefab, copy.transform.position + new Vector3(0.3f, 0, 0), Quaternion.Euler(0.0f, 0.0f, 0.0f));
        copy.GetComponent<EnemigoControllerFase2>().speed = 0.3f;
    }

    void SpawnEnemyType3()
    {
        GameObject copy;
        int random = Mathf.Abs(Random.Range(0, 4));
        copy = Instantiate(prefab, spawners[random].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        copy.GetComponent<EnemigoControllerFase2>().speed = 0.9f;
    }

    void SpawnEnemyType4()
    {
        GameObject copy;
        int random = Mathf.Abs(Random.Range(0, 4));
        copy = Instantiate(prefab, spawners[random].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        copy.GetComponent<EnemigoControllerFase2>().speed = 0.4f;
    }
    */


}
