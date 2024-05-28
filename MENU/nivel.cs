using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nivel : MonoBehaviour
{

    public Player player;


    public Image barraVida;
    public float ValorExp;
    public float NivelMax;


    void Update()
    {

        ValorExp = player.exp;

        barraVida.fillAmount = ValorExp / NivelMax;




    }
}
