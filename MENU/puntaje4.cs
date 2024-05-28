using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje4 : MonoBehaviour
{
    private Text p4;
    public float p4f;
    public string puntajeS4;

    public Player player;

    private void Start()
    {

        p4 = GetComponent<Text>();

        p4f = player.MejoresPuntajes[3];

        puntajeS4 = p4f.ToString();

        p4.text = puntajeS4;




    }
}
