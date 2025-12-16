using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ManagerColocarPersonajes : MonoBehaviour
{
    // Personaje comienza en X = -561. Ventana X = 65. Desaparece en X = -561
    public int a = 0;
    public RectTransform personaje;
    private float velocidad = 800f;

    [Header("Listas")]
    public List<Sprite> Personajes;
    public List<Sprite> billetes;

    [Header("Gameobject")]
    public GameObject Personaje;
    public GameObject Billetes;
    public Image PersonajeI;
    public Image BilleteI;

    public int contador = 0, boton = 0;
    private bool MostrarBill = false, AdsBill = false;

    private float crono = 0f;
    private bool Crono = true;

    public AudioSource audio;

    void Start()
    {
        a = 1;
    }

    void Update()
    {
        if (a == 1)
        {
            personaje.anchoredPosition = Vector2.MoveTowards(
                personaje.anchoredPosition,
                new Vector2(65, personaje.anchoredPosition.y),
                800 * Time.deltaTime);
            PersonajeI.sprite = Personajes[contador];

            if (!MostrarBill)
            {
                StartCoroutine(MostrarBillete());
                MostrarBill = true;
            }
            
            
        }

        if (a == 2)
        {
            personaje.anchoredPosition = Vector2.MoveTowards(
                personaje.anchoredPosition,
                new Vector2(-561, personaje.anchoredPosition.y),
                800 * Time.deltaTime);

            if (AdsBill)
            {
                StartCoroutine(AdsBillete());
            }
        }

        ColocarJugadores();

        if (Crono)
        {
            crono += Time.deltaTime;
        }
    }

    private void ColocarJugadores()
    {
        if(contador == 0 && boton == 3)
        {
            AdsBill = true;
            a = 2;
            contador = 1;

        }

        if (contador == 1 && boton == 1)
        {
            AdsBill = true;
            a = 2;
            contador = 2;
        }

        if (contador == 2 && boton == 2)
        {
            AdsBill = true;
            a = 2;
            contador = 3;
        }

        if (contador == 3 && boton == 1)
        {
            AdsBill = true;
            a = 2;
            contador = 4;
        }

        if (contador == 4 && boton == 2)
        {
            AdsBill = true;
            contador = 5;
            a = 2;
        }

        if (contador == 5 && boton == 4)
        {
            AdsBill = true;
            contador = 6;
            a = 2;
        }

        if (contador == 6 && boton == 2)
        {
            AdsBill = true;
            Crono = false;
            a = 2;

            CronometroTotal.Instance.TiempoTotal += crono;
            SceneManager.LoadScene("Vagon 3");
        }
    }

    IEnumerator MostrarBillete()
    {
        yield return new WaitForSeconds(1f);

        Billetes.SetActive(true);
        BilleteI.sprite = billetes[contador];

        StopAllCoroutines();
        yield break;
    }

    IEnumerator AdsBillete()
    {
        Billetes.SetActive(false);

        yield return new WaitForSeconds(2f);

        a = 1;
        boton = 0;
        MostrarBill = false;
        StopAllCoroutines();
        yield break;
    }


    public void Boton1()
    {
        audio.Play();
        boton = 1;
    }

    public void Boton2()
    {
        audio.Play();
        boton = 2;
    }

    public void Boton3()
    {
        audio.Play();
        boton = 3;
    }

    public void Boton4()
    {
        audio.Play();
        boton = 4;
    }
}
