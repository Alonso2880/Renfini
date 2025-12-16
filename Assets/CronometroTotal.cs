using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroTotal : MonoBehaviour
{
    public static CronometroTotal Instance {  get; private set; }

    public float TiempoTotal;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Si quieres que persista entre escenas
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
