using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ManagerGeneral : MonoBehaviour
{
    /*
     Orden Minijuegos
    1.Simon Dice: Primero deberás demostrar que sabes seguir las órdenes de los demás, así que haremos un simulacro con mi simón dice. Sigue los patrones de colores en orden ¡No te equivoques!
    2.Ordenar personajes: Bien hecho, ahora irás a ordenar a los diferentes pasajeros. Fíjate en su billete y mándalos al vagón correspondiente.
    3.Ordenar Maletas: Lo siguiente son las maletas, ordénalas de forma ordenada.
    4.Repartir Comida: Esta será tu última tarea con los clientes, ellos te irán pidiendo comida y se las vas a repartir. ¡Rápido!
    5.Clave: Se ha cerrado la puerta al interior de la maquinaria del tren. Para abrirla necesito meter la clave y luego usar las llaves. Dónde tendré la clave apuntada....
    6.LLaves
    7.Unir Cables: ¡Wow! ¿Cómo sabes la clave? Bueno da igual. Varios cables se han roto, si quieres ayudar intenta unirlos para repararlos. Si no pues a esperar al electricista...
    8.Simulacro palanca emergencia: ¡Bien hecho! Y solo queda comprobar las palancas, cuando yo te diga pulsa la palanca de emergencia.
    9.Palancas en el vagon del piloto: Solo queda una cosa más, comprobar que funcionan las palancas de cabina. Para que arranque el tren se deben bajar en un determinado orden, pero no sé cuál es....
     */
    public GameObject PersonajePrincipal2, personajePrincipal, caja;
    public List<TextMeshProUGUI> textos;

    public string NombreEscena;

    private bool Empezar = false;
    public int orden = 0;
    void Start()
    {
        StartCoroutine(Mostrar());
    }

    void Update()
    {
        if(Empezar)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                textos[orden].gameObject.SetActive(false);
                orden++;

                if (orden < textos.Count)
                {
                    textos[orden].gameObject.SetActive(true);
                }
                else
                {
                    textos[orden - 1].gameObject.SetActive(false);
                    caja.SetActive(false);
                    SceneManager.LoadScene(NombreEscena);
                }
            }
        }
    }

    IEnumerator Mostrar()
    {
        yield return new WaitForSeconds(1f);
        personajePrincipal.SetActive(false);
        PersonajePrincipal2.SetActive(true);
        textos[orden].gameObject.SetActive(true);
        caja.SetActive(true);
        Empezar = true;

        StopAllCoroutines();
        yield break;

    }
}
