using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje1 : MonoBehaviour
{

    private Text p1;
    public float p1f;
    public string puntajeS1;

    public Player player;

    private void Start()
    {

        p1 = GetComponent<Text>();

        p1f = player.MejoresPuntajes[0];

        puntajeS1 = p1f.ToString();

        p1.text = puntajeS1;




    }




}
