using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject reanudar;
    public GameObject casa_pausa;

    public AudioSource musica;

    public void Start()
    {

        reanudar.SetActive(false);
        casa_pausa.SetActive(false);


    }
    public void Pause()
    {

        Time.timeScale = 0f;
        musica.spatialBlend = 0.8f;
        reanudar.SetActive(true);
        casa_pausa.SetActive(true);

    }

    public void Resume()
    {

        Time.timeScale = 1f;
        musica.spatialBlend = 0;
        reanudar.SetActive(false);
        casa_pausa.SetActive(false);


    }

  
}
