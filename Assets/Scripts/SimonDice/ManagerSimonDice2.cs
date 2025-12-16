using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerSimonDice2 : MonoBehaviour
{
    public float duracion = 0.3f;
    public int turno = 1;

    private bool turnoAct = false;

    private float Cronometro = 0f;
    private bool Cronos = true;
    void Start()
    {
        StartCoroutine(Turno1());
    }

    void Update()
    {
        if (Cronos)
        {
            Cronometro += Time.deltaTime;
        }


        ManagerSimonDice sd = this.GetComponent<ManagerSimonDice>();

        if(turno == 1)
        {
            if (sd.Amarillo)
            {
                if (sd.Azul)
                {
                    turno = 2;
                    turnoAct = true;
                    sd.Amarillo = sd.Azul = false;
                }
            }
        }

        if(turno == 2)
        {
          
            //StopAllCoroutines();
            if (turnoAct)
            {
                StartCoroutine(Turno2());
                turnoAct = false;
            }
            
            if (sd.Amarillo)
            {
                if (sd.Azul)
                {
                    if (sd.Verde)
                    {
                        turno = 3;
                        turnoAct = true;

                        sd.Amarillo = sd.Azul = sd.Verde = false;
                    }
                }
            }
        }

        if (turno == 3)
        {

            //StopAllCoroutines();
            if (turnoAct)
            {
                StartCoroutine(Turno3());
                turnoAct = false;
            }
            
            if (sd.Amarillo)
            {
                if (sd.Azul)
                {
                    if (sd.Verde)
                    {
                        if (sd.Rojo)
                        {
                            turno = 4;
                            turnoAct = true;
                            sd.Amarillo = sd.Azul = sd.Verde = sd.Rojo = false;
                        }
                    }
                }
            }
        }

        if (turno == 4)
        {
            

            //StopAllCoroutines();
            if (turnoAct)
            {
                StartCoroutine(Turno4());
                turnoAct = false;
            }
            
            if (sd.Verde)
            {
                if (sd.Rojo)
                {
                    if (sd.Azul)
                    {
                        if (sd.Amarillo)
                        {
                            turno = 5;
                            turnoAct = true;
                            sd.Amarillo = sd.Azul = sd.Verde = sd.Rojo = false;
                        }
                    }
                }
            }
        }


        if (turno == 5)
        {
            

            //StopAllCoroutines();
            if (turnoAct)
            {
                StartCoroutine(Turno5());
                turnoAct = false;
            }
            
            if (sd.Azul)
            {
                if (sd.Rojo)
                {
                    if (sd.Amarillo)
                    {
                        Cronos = false;
                        CronometroTotal.Instance.TiempoTotal = Cronometro;
                        SceneManager.LoadScene("Vagon 2");
                    }
                }
            }
        }
    }

    IEnumerator Turno1()
    {
        ManagerSimonDice sd = this.GetComponent<ManagerSimonDice>();

        yield return new WaitForSeconds(0.4f);
        sd.HighlightAM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightAzM();
        yield break;
    }

    IEnumerator Turno2()
    {
        ManagerSimonDice sd = this.GetComponent<ManagerSimonDice>();

        yield return new WaitForSeconds(0.4f);
        sd.HighlightAM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightAzM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightVM();
        yield break;
    }

    IEnumerator Turno3()
    {
        ManagerSimonDice sd = this.GetComponent<ManagerSimonDice>();

        yield return new WaitForSeconds(0.4f);
        sd.HighlightAM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightAzM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightVM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightRM();
        yield break;
    }

    IEnumerator Turno4()
    {
        ManagerSimonDice sd = this.GetComponent<ManagerSimonDice>();

        yield return new WaitForSeconds(0.4f);
        sd.HighlightVM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightRM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightAzM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightAM();
        yield break;
    }

    IEnumerator Turno5()
    {
        ManagerSimonDice sd = this.GetComponent<ManagerSimonDice>();

        yield return new WaitForSeconds(0.4f);
        sd.HighlightAzM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightRM();
        yield return new WaitForSeconds(0.4f);
        sd.HighlightAM();
        yield break;
    }
}
