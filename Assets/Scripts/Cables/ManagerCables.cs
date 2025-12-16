using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerCables : MonoBehaviour
{
    public List<GameObject> cables;

    private bool C1 = false, C2 = false, A1 = false, A2 = false, V1 = false, V2 = false, R1 = false, R2 = false, M1 = false, M2 = false, Ve1 = false, Ve2 = false;
    private int contador = 0;
    private int cont = 0;

    private float cronometro = 0;
    private bool cronos=true;

    private bool ConC = true, ConA = true, ConV = true, ConR = true, ConM = true, ConVe = true;

    void Update()
    {
        if(cont >= 6)
        {
            cronos = false;
            CronometroTotal.Instance.TiempoTotal += cronometro;
            SceneManager.LoadScene("Vagon 7");
        }

        if (cronos)
        {
            cronometro += Time.deltaTime;
        }

        if(C1 && C2)
        {
            cables[0].gameObject.SetActive(true);
            if (ConC)
            {
                cont++;
                ConC = false;
            }
            
        }

        if(A1 && A2)
        {
            cables[1].gameObject.SetActive(true);
            if (ConA)
            {
                cont++;
                ConA = false;
            }
            
        }

        if(V1 && V2)
        {
            cables[2].gameObject.SetActive(true);
            if (ConV)
            {
                cont++;
                ConV = false;
            }
            
        }

        if(R1 && R2)
        {
            cables[3].gameObject.SetActive(true);
            if (ConR)
            {
                cont++;
                ConR = false;
            }
            
        }

        if(M1 && M2)
        {
            cables[5].gameObject.SetActive(true);
            if (ConM)
            {
                cont++;
                ConM = false;
            }
            
        }

        if (Ve1 && Ve2)
        {
            cables[4].gameObject.SetActive(true);
            if (ConVe)
            {
                cont++;
                ConVe = false;
            }
            
        }
    }

    public void Cyan1()
    {
        C1 = true;
        contador++;
    }

    public void Cyan2()
    {
        C2 = true;
        contador++;
    }

    public void Azul1()
    {
        A1 = true;
        contador++;
    }

    public void Azul2()
    {
        A2 = true;
        contador++;
    }
    public void Violeta1()
    {
        V1 = true;
        contador++;
    }

    public void Violeta2()
    {
        V2 = true;
        contador++;
    }

    public void Rojo1()
    {
        R1 = true;
        contador++;
    }

    public void Rojo2()
    {
        R2 = true;
        contador++;
    }

    public void Morado1()
    {
        M1 = true;
        contador++;
    }

    public void Morado2()
    {
        M2 = true;
        contador++;
    }

    public void Verde1()
    {
        Ve1= true;
        contador++;
    }

    public void Verde2()
    {
        Ve2 = true;
        contador++;
    }
}
