using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nivelNumero : MonoBehaviour
{
    public Player player;

    private Text Nivel;

    public string NivelS;
    public float ValorNivel;
    void Start()
    {
        Nivel = GetComponent<Text>();
    }


    void Update()
    {

        ValorNivel = player.nivel;
        NivelS = ValorNivel.ToString();
        Nivel.text = NivelS;
    }
}
