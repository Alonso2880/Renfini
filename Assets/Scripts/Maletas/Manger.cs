using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manger : MonoBehaviour
{
    [Tooltip("Lista de los slots de la escena")]
    public ItemSlot[] allSlots;

    [HideInInspector] public int score = 0;

    private float crono;
    private bool Crono = false;

    private void Update()
    {
        if (!Crono)
        {
            crono += Time.deltaTime;
        }
    }

    public void CheckSlots()
    {
        score = 0;
        Crono = true;

        for (int i=0;  i<allSlots.Length; i++)
        {
            if (allSlots[i].transform.childCount > 0)
            {
                GameObject objHijo = allSlots[i].transform.GetChild(0).gameObject;
                DragDrop dr = objHijo.GetComponent<DragDrop>();

                if (dr.itemID == allSlots[i].slotID)
                {
                    score++;
                }
            }
        }

        Debug.Log(score);
        

        CronometroTotal.Instance.TiempoTotal += crono;
        SceneManager.LoadScene("Vagon 4");
    }




    public void CheckSlotsLLaves()
    {
        score = 0;
        Crono = true;

        for (int i = 0; i < allSlots.Length; i++)
        {
            if (allSlots[i].transform.childCount > 0)
            {
                GameObject objHijo = allSlots[i].transform.GetChild(0).gameObject;
                DragDrop dr = objHijo.GetComponent<DragDrop>();

                if (dr.itemID == allSlots[i].slotID)
                {
                    score++;
                }
            }
        }

        Debug.Log(score);


        CronometroTotal.Instance.TiempoTotal += crono;
        SceneManager.LoadScene("Vagon 6");
    }
}
