using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerFase2 : MonoBehaviour {

    public int life;
    public int score;
    GameObject[] spawners;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    Text vidas;
    GameObject victoria;
    GameObject puntosFinales;

    void Start ()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        vidas = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Text>();
        vidas.text = life.ToString();
        victoria = GameObject.FindGameObjectWithTag("Victoria");
        victoria.SetActive(false);
        InvokeRepeating("SpawnEnemyType1", 20.0f, 15f);  //yeah
        InvokeRepeating("SpawnEnemyType2", 15.0f, 10f);  //pau tururu
        InvokeRepeating("SpawnEnemyType3", 10.0f, 5f);   //turu turu turu
        InvokeRepeating("SpawnEnemyType4", 5.0f, 2f);    //tun
        
    }

    void Update()
    {
        if (life <= 0)
        {
            Time.timeScale = 0;
            victoria.SetActive(true);
            puntosFinales = GameObject.FindGameObjectWithTag("puntosVictoria");
            puntosFinales.GetComponent<Text>().text = score.ToString();
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }else if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }
    }

    void SpawnEnemyType1()
    {
        Instantiate(prefab1, spawners[Mathf.Abs(Random.Range(0, 4))].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
    }

    void SpawnEnemyType2()
    {
        Instantiate(prefab2, spawners[Mathf.Abs(Random.Range(0, 4))].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
    }

    void SpawnEnemyType3()
    {
        Instantiate(prefab3, spawners[Mathf.Abs(Random.Range(0, 4))].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
    }

    void SpawnEnemyType4()
    {
        Instantiate(prefab4, spawners[Mathf.Abs(Random.Range(0, 4))].transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
    }



}
