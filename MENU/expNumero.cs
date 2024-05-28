using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class expNumero : MonoBehaviour
{
    public Player player;

    private Text exp;

    public string expS;
    public float Valorexp;
    void Start()
    {
        exp = GetComponent<Text>();
    }


    void Update()
    {

        Valorexp = player.exp;
        expS = Valorexp.ToString();
        exp.text = expS;
    }
}