using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerRepartir : MonoBehaviour
{
    public List<GameObject> pedidos;
    public int fase = 0;

    private int galletas = 0, chips = 0, snacks = 0, barritas = 0, cola = 0, chicle = 0, caramelo = 0;
    private float crono = 0;
    private bool Crono = true;
    void Update()
    {
        if (Crono)
        {
            crono += Time.deltaTime;
        }


        if(fase == 0)
        {
            pedidos[fase].gameObject.SetActive(true);

            if(galletas >= 2 && barritas >= 1 && cola >= 1)
            {
                pedidos[fase].gameObject.SetActive(false);
                galletas = barritas = cola = 0;
                fase++;
            }
        }

        if (fase == 1)
        {
            pedidos[fase].gameObject.SetActive(true);

            if(snacks >= 1 && chicle >= 1 && chips >= 1 && cola >= 1)
            {
                pedidos[fase].gameObject.SetActive(false);
                snacks = chicle = chips = cola = 0;
                fase++;
            }
        }

        if (fase == 2)
        {
            pedidos[fase].gameObject.SetActive(true);

            if(chicle >= 1 && barritas >= 1 && caramelo >= 3)
            {
                pedidos[fase].gameObject.SetActive(false);
                chicle = barritas = caramelo = 0;
                fase++;
            }
        }

        if (fase == 3)
        {
            pedidos[fase].gameObject.SetActive(true);

            if(chips >= 1 && galletas >= 1 && snacks >= 1)
            {
                pedidos[fase].gameObject.SetActive(false);
                chips = galletas = snacks = 0;
                Crono = false;

                CronometroTotal.Instance.TiempoTotal += crono;
                SceneManager.LoadScene("Vagon 5");
            }
        }
    }


    //Metodos botones
    public void Galletas()
    {
        galletas++;
    }

    public void Chips()
    {
        chips++;
    }

    public void Snacks()
    {
        snacks++;
    }

    public void Barritas()
    {
        barritas++;
    }

    public void Cola()
    {
        cola++;
    }

    public void Chicle()
    {
        chicle++;
    }

    public void Caramelo()
    {
        caramelo++;
    }
}
