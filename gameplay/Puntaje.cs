using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Player player;
    private float puntos;
    private Text textMesh;


    [SerializeField]
    Animator animacion;



    private void Start()
    {
        textMesh = GetComponent<Text>();
    }
    public void sumarPuntos(int x)
    {
        animacion.SetBool("sumaPuntaje", true);
        puntos = puntos + x;
        textMesh.text = puntos.ToString("0");
        StartCoroutine("tiempoAnim");


    }

    public IEnumerator tiempoAnim()
    {
        yield return new WaitForSeconds(0.2f);
        animacion.SetBool("sumaPuntaje", false);


    }


    public void guardarpuntos()
    {
        player.guardarPuntaje(puntos);
        Debug.Log(puntos);
    }
}
