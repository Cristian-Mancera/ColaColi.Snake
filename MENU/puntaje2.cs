using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje2 : MonoBehaviour
{
    private Text p2;
    public float p2f;
    public string puntajeS2;

    public Player player;

    private void Start()
    {

        p2 = GetComponent<Text>();

        p2f = player.MejoresPuntajes[1];

        puntajeS2 = p2f.ToString();

        p2.text = puntajeS2;




    }
  
}
