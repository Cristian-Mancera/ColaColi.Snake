using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje3 : MonoBehaviour
{
    private Text p3;
    public float p3f;
    public string puntajeS3;

    public Player player;

    private void Start()
    {

        p3 = GetComponent<Text>();

        p3f = player.MejoresPuntajes[2];

        puntajeS3 = p3f.ToString();

        p3.text = puntajeS3;




    }
}
