using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerMenuPrincipal : MonoBehaviour
{
    public Canvas canvas;
    public Animator animator;
    public GameObject panel;

    private float color = 0;
    private bool colorB = false;

    public AudioSource tren;
    public AudioSource sonidoBoton;

    private void Update()
    {
        Image imagen = panel.GetComponent<Image>();
        Color colorI = imagen.color;

        if (colorB && color < 1)
        {
            color += Time.deltaTime;
            colorI.a = color;
            imagen.color = colorI;
        }
    }

    public void Exist()
    {
        sonidoBoton.Play();
        Application.Quit();
    }

    public void Credits()
    {
        sonidoBoton.Play();
        SceneManager.LoadScene("Creditos");
    }

    public void Play()
    {
        sonidoBoton.Play();
        tren.Play();
        StartCoroutine(Jugar());
    }

    IEnumerator Jugar()
    {
        animator.SetBool("Activado", true);
        canvas.enabled = true;

        colorB = true;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("VagónInicio");
        yield return null;


    }
}
