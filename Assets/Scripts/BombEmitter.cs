//--------IMPORTS----------
using UnityEngine;
using System.Collections;

//----NOMBRE DE LA CLASE : (EXTENDS) MonoBehaviour------
public class BombEmitter : MonoBehaviour
{
    //-----------ATRIBUTOS DE LA CLASE----------------
    //SI LA VARIABLE ES PUBLICA,
    //PODEMOS ACCEDER A ELLA A TRAVÉS DE OTROS
    //SCRIPTS E INCLUSO DIRECTAMENTE DESDE UNITY
    public GameObject bombPrefab;//NULL POR DEFECTO

    // ------------FUNCIONES - MÉTODOS-------------
    //FUNCION QUE SE EJECUTA EN EL PRIMER FRAME
    //AL INICIAR EL VIDEOJUEGO
    void Start ()
    {
        StartCoroutine (DropBombs ());
    }
    //FUNCION ESPECIAL --> CORRUTINA
    //PUEDE REALIZAR PAUSAS DURANTE X SEGUNDOS HASTA QUE TERMINAN
    IEnumerator DropBombs ()
    {
        //BUCLE QUE CREA BOMBAS CADA 2 SEGUNDOS,
        //MIENTRAS EL JUEGO ESTE EN FUNCIONAMIENTO
        while (Application.isPlaying)
        {
            CreateBomb ();
            //RETORNA LA EJECUCION AL MICRO //DURANTE 2 SEGUNDOS
            yield return new WaitForSeconds (2);
        }
    }
    //FUNCION CREAR BOMBA
    void CreateBomb ()
    {
        if (bombPrefab != null)
        {
            //FUNCION INICIALIZAR //BOMBA=bombPrefab , transform.position=LUGAR DE CREACIÓN,
            //transform.rotation=ROTACION DEL OBJETO
            Instantiate(bombPrefab, transform.position, bombPrefab.transform.rotation);
        }
    }
}
