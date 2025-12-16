using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerPalanca : MonoBehaviour
{
    public List<Button> botones;
    public List<Image> palancas;
    public Animator palanca1, palanca2, palanca3, palanca4;
    
    private bool pa2 = false, pa3 = false, pa4 = false, cronoStart = false;

    private float cronometro = 0;
    void Start()
    {
        botones[1].gameObject.SetActive(false);
        botones[2].gameObject.SetActive(false);
        botones[3].gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (cronoStart)
        {
            cronometro += Time.deltaTime;
        }
        if (pa2)
        {
            botones[1].gameObject.SetActive(true);
        }

        if (pa3)
        {
            botones[2].gameObject.SetActive(true);
        }

        if (pa4)
        {
            botones[3].gameObject.SetActive(true);
        }
    }

    public void palanca1Click()
    {
        cronoStart = true;
        StartCoroutine(CorrutinaPalanca1());
    }

    public void palanca2Click()
    {
        StartCoroutine(CorrutinaPalanca2());
    }

    public void palanca3Click()
    {
        StartCoroutine(CorrutinaPalanca3());
    }

    public void palanca4Click()
    {
        StartCoroutine(CorrutinaPalanca4());
    }
    
    IEnumerator CorrutinaPalanca1()
    {
        palanca1.SetBool("Palanca1", true);
        botones[0].gameObject.SetActive(false);

        yield return new WaitForSeconds(0.6f);

        palanca1.SetBool("Palanca1", false);
        pa2 = true;

        StopAllCoroutines();
        yield return null;
    }
    
    IEnumerator CorrutinaPalanca2()
    {
        palanca2.SetBool("Palanca2", true);
        botones[1].gameObject.SetActive(false);

        yield return new WaitForSeconds(0.6f);

        palanca2.SetBool("Palanca2", false);
        pa3 = true;

        StopAllCoroutines();
        yield return null;
    }
    
    IEnumerator CorrutinaPalanca3()
    {
        palanca3.SetBool("Palanca3", true);
        botones[2].gameObject.SetActive(false);

        yield return new WaitForSeconds(0.6f);

        palanca3.SetBool("Palanca3", false);
        pa4 = true;

        StopAllCoroutines();
        yield return null;
    }
    
    IEnumerator CorrutinaPalanca4()
    {
        palanca4.SetBool("Palanca4", true);
        botones[3].gameObject.SetActive(false);

        yield return new WaitForSeconds(0.6f);

        palanca4.SetBool("Palanca4", false);
        cronoStart = false;

        yield return new WaitForSeconds(1f);
        StopAllCoroutines();

        CronometroTotal.Instance.TiempoTotal += cronometro;
        SceneManager.LoadScene("Final");

        yield return null;
    }
}
