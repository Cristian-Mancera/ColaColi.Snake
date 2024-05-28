using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{

    public GameObject Reset;
    public GameObject CASA;
    public GameObject mensajeGameOver;
    public GameObject Fondo;

    [SerializeField]
    Animator animacion;

    [SerializeField]
    Animator animacionPuntaje;

    // Start is called before the first frame update
    void Start()
    {
        Reset.gameObject.SetActive(false);
        CASA.gameObject.SetActive(false);
        mensajeGameOver.gameObject.SetActive(false);
        Fondo.gameObject.SetActive(false);
    }


    public void resetBoton()
    {

        Reset.gameObject.SetActive(true);
        CASA.gameObject.SetActive(true);
        mensajeGameOver.gameObject.SetActive(true);
        Fondo.gameObject.SetActive(true);
        animacion.SetBool("gameOver",true);
        animacionPuntaje.SetBool("gameOver",true);


    }
}
