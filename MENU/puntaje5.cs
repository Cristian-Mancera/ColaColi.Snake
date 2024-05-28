using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje5 : MonoBehaviour
{
   private Text p5;
    public float p5f;
    public string puntajeS5;

    public Player player;

    private void Start()
    {

        p5 = GetComponent<Text>();

        p5f = player.MejoresPuntajes[4];

        puntajeS5 = p5f.ToString();

        p5.text = puntajeS5;




    }
}
