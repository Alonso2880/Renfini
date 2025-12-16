using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FinalManager : MonoBehaviour
{
    public float Tiempo;

    public Sprite gana, pierde;
    public Image Fondo;
    public TextMeshProUGUI ganaT, pierdeT;
    void Start()
    {
        Tiempo = CronometroTotal.Instance.TiempoTotal;

        if(Tiempo <= 140)
        {
            Fondo.sprite = gana;
            ganaT.gameObject.SetActive(true);
        }

        if(Tiempo > 140)
        {
            Fondo.sprite = pierde;
            pierdeT.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exist()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Play()
    {
        CronometroTotal.Instance.TiempoTotal = 0;
        SceneManager.LoadScene("VagónInicio");
    }
}
