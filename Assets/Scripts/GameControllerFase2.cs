using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerFase2 : MonoBehaviour {

    public float life;
    public int score;
    GameObject[] spawners;
    public GameObject prefab;
    public float speed = 0.5f;

	void Start () {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
	}
	
	
	void Update () {
        Debug.Log(Time.time);
		if(Time.time%5 == 0)
        {
            int random = Mathf.Abs(Random.Range(0, 3));
            Instantiate(prefab, spawners[random].transform.position,Quaternion.Euler(0.0f,0.0f,0.0f));
        }
	}
}
