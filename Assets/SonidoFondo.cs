using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoFondo : MonoBehaviour
{
    public static SonidoFondo Instance { get; private set; }

    public AudioSource Musica;
    private void Awake()
    {
        Musica.Play();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
