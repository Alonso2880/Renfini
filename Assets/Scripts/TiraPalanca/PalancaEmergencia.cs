using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PalancaEmergencia : MonoBehaviour
{
    public Canvas canva;
    public Animator animator;
    public Button palanca;
    public TextMeshProUGUI texto;

    private float tiempo;
    public float Cronometro = 0;
    private bool Crono = false;
    private void Start()
    {
        texto.gameObject.SetActive(false);
        tiempo = Random.Range(3, 8);

        StartCoroutine(Parar());
    }

    private void Update()
    {
        if (Crono)
        {
            Cronometro += Time.deltaTime;
        }
    }

    public void TirarPalanca()
    {
        StartCoroutine(CorrutinaPalanca());

    }

    IEnumerator CorrutinaPalanca()
    {
        animator.SetBool("Activado", true);
        Crono = false;
        palanca.gameObject.SetActive(false);

        yield return new WaitForSeconds(0.6f);

        animator.SetBool("Activado", false);

        yield return new WaitForSeconds(1f);

        CronometroTotal.Instance.TiempoTotal += Cronometro;
        SceneManager.LoadScene("Vagon 8");

        yield return null;
    }

    IEnumerator Parar()
    {
        yield return new WaitForSeconds(tiempo);

        texto.gameObject.SetActive(true);
        Crono = true;
    }
}
