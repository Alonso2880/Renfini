using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerSimonDice : MonoBehaviour
{
    public Image Brojo, Bverde, Bamarillo, Bazul;
    public float duracion = 0.3f;

    public bool Rojo = false, Azul = false, Verde = false, Amarillo = false;

    Color32 normal = new Color32(166, 166, 166, 255);
    Color32 iluminado = new Color32(255, 255, 255, 255);

    public AudioSource audio;

    //Jugador//
    public void HighlightR()
    {
        audio.Play();
        StartCoroutine(Iluminar(Brojo));
        Rojo = true;
    }

    public void HighlightA()
    {
        ManagerSimonDice2 sd2 = this.GetComponent<ManagerSimonDice2>();
        audio.Play();
        StartCoroutine(Iluminar(Bamarillo));
        Amarillo = true;
    }

    public void HighlightV()
    {
        ManagerSimonDice2 sd2 = this.GetComponent<ManagerSimonDice2>();
        audio.Play();
        StartCoroutine(Iluminar(Bverde));
        Verde = true;
    }

    public void HighlightAz()
    {
        audio.Play();
        StartCoroutine(Iluminar(Bazul));
        Azul = true;
    }

    //Maquina//
    public void HighlightRM()
    {
        StartCoroutine(Iluminar(Brojo));
    }

    public void HighlightAM()
    {
        StartCoroutine(Iluminar(Bamarillo));
    }

    public void HighlightVM()
    {
        StartCoroutine(Iluminar(Bverde));
    }

    public void HighlightAzM()
    {
        StartCoroutine(Iluminar(Bazul));
    }
    IEnumerator Iluminar(Image boton)
    {
        boton.color = iluminado;
        yield return new WaitForSeconds(duracion);
        boton.color = normal;
        yield break;
    }
}
