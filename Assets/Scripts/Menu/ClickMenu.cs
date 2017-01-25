using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickMenu : MonoBehaviour {
    private GameObject menuPausa;

    void Start()
    {
        menuPausa = GameObject.FindGameObjectWithTag("Pausa");
        //menuPausa.SetActive(true);
    }

    //MENU PRINCIPAL:
    public void empezarTutorial() {
        SceneManager.LoadScene(1);
    }

    public void empezarModo1() {
        SceneManager.LoadScene(3);
    }

    public void empezarModo2() {
        SceneManager.LoadScene(2);
    }

    public void salir() {
        Application.Quit();
    }

    //MENU DE PAUSA:

    public void volverAlJuego() {
        menuPausa.SetActive(false);
        Time.timeScale = 1;
        MovimientoCharacterController.pausaActivada = false;
    }

    public void volverAEmpezar() {
        menuPausa.SetActive(false);
        Time.timeScale = 1;
        MovimientoCharacterController.pausaActivada = false;
        AudioManagerMio.resetear = true;
        AudioManagerMioTutorial.resetear = true;
        menuPausa.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void volverAlMenuPrincipal() {
        menuPausa.SetActive(false);
        Time.timeScale = 1;
        MovimientoCharacterController.pausaActivada = false;
        AudioManagerMioTutorial.resetear = true;
        AudioManagerMio.resetear = true;
        //menuPausa.SetActive(true);
        SceneManager.LoadScene(0);
    }
}
