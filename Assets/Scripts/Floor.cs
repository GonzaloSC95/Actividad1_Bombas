using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private AudioSource explosionSource;
    public AudioClip explosionSound;
    // Start is called before the first frame update
    void Start()
    {
        explosionSource = GetComponent<AudioSource>();
        //Ahora, cuando la bomba caiga, su sonido irá variando y será diferente cada vez. 
        explosionSource.pitch = UnityEngine.Random.Range(0.8f, 1.5f);

    }

    //EVENTO ON COLISSION ENTER
    private void OnCollisionEnter(Collision collision)
    {
        explosionSource.PlayOneShot(explosionSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
