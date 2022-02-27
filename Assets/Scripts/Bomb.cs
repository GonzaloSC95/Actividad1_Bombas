//IMPORTS
using UnityEngine;
using System.Collections;
using System;
//----NOMBRE DE LA CLASE : (EXTENDS) MonoBehaviour------
public class Bomb : MonoBehaviour
{
    //-----------ATRIBUTOS DE LA CLASE----------------
    //SI LA VARIABLE ES PUBLICA,
    //PODEMOS ACCEDER A ELLA A TRAVÉS DE OTROS
    //SCRIPTS E INCLUSO DIRECTAMENTE DESDE UNITY
    public GameObject explosionParticlesPrefab;//NULL POR DEFECTO
    private Rigidbody bombaRigigBody;//NULL POR DEFECTO
    //--------------------------------------------
    private float limiteInferior = 10f;
    private float limiteSuperior = 100f;
    // ------------FUNCIONES - MÉTODOS-------------
    //FUNCION QUE SE EJECUTA EN EL PRIMER FRAME
    //AL INICIAR EL VIDEOJUEGO
    void Start ()
    {
        //LE ASIGNAMOS UNA PEQUEÑA ROTACIÓN A LA BOMBA AL INICIO DE LA APLICACIÓN
        float x = UnityEngine.Random.Range(limiteInferior, limiteSuperior);
        float y = UnityEngine.Random.Range(limiteInferior, limiteSuperior);
        float z = UnityEngine.Random.Range(limiteInferior, limiteSuperior);
        //---------------------------------------------
        bombaRigigBody = GetComponent<Rigidbody>();
        bombaRigigBody.AddTorque(x,y,z);//x,y,z

    }

    //FUNCION CREAR EXPOSION AL COLISIONAR
    //FUNCIONES QUE EMPIEZAN POR ON*** = EVENTOS
    public void OnCollisionEnter (Collision collision)
    {
        //SI EL OBJETO QUE COLISIONA ES GameObject explosionParticlesPrefab
        if (explosionParticlesPrefab)
        {
            //SE INSTANCIA OTRO OBJETO GameObject LLAMADO EXPLOSION -->
            //EXPLOSION = explosion , transform.position = LUGAR DE CREACIÓN,
            //transform.rotation=ROTACION DEL OBJETO
            GameObject explosion = (GameObject)Instantiate (explosionParticlesPrefab, transform.position,
                explosionParticlesPrefab.transform.rotation);
            //SE DSTRUYE EL OBJETO EXPLOSION EN LA ESCENA
            Destroy (explosion, explosion.GetComponent<ParticleSystem> ().main.startLifetimeMultiplier);
            //OBJETO A DESTRUIR, OBJETO.GetComponente.SISTEMA DE PARTICULAS.DENTRO DE MAIN.TIEMPO DE VIDA DE LA EXPLOSION
        }
        //SE DSTRUYE EL OBJETO BOMBA
        Destroy(gameObject);
    }

}
