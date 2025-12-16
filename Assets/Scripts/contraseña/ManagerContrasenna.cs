using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerContrasenna : MonoBehaviour
{
    public Button Go, uno, dos, tres, cuatro, cinco, seis, siete, ocho, nueve;
    private int numero, conta = 0;
    public GameObject Botones;

    private string clave = "1941";
    private string cont = "";
    private float crono = 0;
    private bool cronos = true;

    public AudioSource audio;
    void Start()
    {
        Go.onClick.AddListener((GO));
        uno.onClick.AddListener((UNO));
        dos.onClick.AddListener((DOS));
        tres.onClick.AddListener((TRES));
        cuatro.onClick.AddListener((CUATRO));
        cinco.onClick.AddListener((CINCO));
        seis.onClick.AddListener((SEIS));
        siete.onClick.AddListener((SIETE));
        ocho.onClick.AddListener((OCHO));
        nueve.onClick.AddListener((NUEVE));
    }

    // Update is called once per frame
    void Update()
    {
        if(conta == 4)
        {
            Botones.SetActive(false);
        }

        if (cronos)
        {
            crono += Time.deltaTime;
        }
    }

    public void GO()
    {
        StartCoroutine(FadeBlack(Go));
        Debug.Log(cont);
        cronos = false;

        if (cont == clave)
        {
            Debug.Log("Correcto");
            conta = 0;

            CronometroTotal.Instance.TiempoTotal += crono;
            SceneManager.LoadScene("Llaves");
        }
        else
        {
            cont = "";
            conta = 0;
        }
    }

    public void UNO()
    {
        audio.Play();
        numero = 1;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void DOS()
    {
        audio.Play();
        numero = 2;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void TRES()
    {
        audio.Play();
        numero = 3;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void CUATRO()
    {
        audio.Play();
        numero = 4;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void CINCO()
    {
        audio.Play();
        numero = 5;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void SEIS()
    {
        audio.Play();
        numero = 6;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void SIETE()
    {
        audio.Play();
        numero = 7;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void OCHO()
    {
        audio.Play();
        numero = 8;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }

    public void NUEVE()
    {
        audio.Play();
        numero = 9;
        cont = cont + numero.ToString();
        numero = 0;
        conta++;
    }


    IEnumerator FadeBlack(Button Boton)
    {
        float colortope = 0.55f;
        float color = 0f;

        Image imagen = Boton.GetComponent<Image>();
        Color colorI = imagen.color;

        colorI.a = 0.55f;
        imagen.color = colorI;

        yield return new WaitForSeconds(0.2f);

        colorI.a = 0f;
        imagen.color = colorI;

        yield return null;
    }
}
