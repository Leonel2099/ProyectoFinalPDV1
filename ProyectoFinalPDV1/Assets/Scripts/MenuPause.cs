using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    //[SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    private bool juegoPausado = false;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                
                Reanudar();
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
                Pausa();
            }
        }
    }
    public void Pausa()
    {
        juegoPausado = true;
        //Para que el juego se detenga
        Time.timeScale = 0f;
        //botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        juegoPausado = false;
        Time.timeScale = 1f;
        //botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}
