using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickMenu : MonoBehaviour {
    
    public void empezarTutorial() {
        SceneManager.LoadScene(1);
    }

    public void empezarModo1() {
        SceneManager.LoadScene(2);
    }

    public void empezarModo2() {
        SceneManager.LoadScene(3);
    }

    public void salir() {
        Application.Quit();
    }
}
