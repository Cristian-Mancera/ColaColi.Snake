using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoComida : MonoBehaviour
{

    private AudioSource audioSource;

    public AudioClip comida;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    
    public void comidaSonido(){

        audioSource.PlayOneShot(comida);
    }
}
