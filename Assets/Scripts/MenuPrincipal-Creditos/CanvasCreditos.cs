using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasCreditos : MonoBehaviour
{
    public AudioSource sonidoBoton;
    public void vueltaMenu()
    {
        sonidoBoton.Play();
        SceneManager.LoadScene("MenuPrincipal");
    }
}
