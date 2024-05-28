using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int Nskin;
    public int musicV;
    public float Puntaje_Global;
    public float nivel;
    public float exp;
    public bool DarkScreen;
    public float[] MejoresPuntajes = new float[5];


    public PlayerData(Player player)
    {
        Puntaje_Global = player.puntajeGlobal;
        nivel = player.nivel;
        exp = player.exp;
        DarkScreen = player.DarkScreen;
        Nskin = player.Nskin;
        musicV = player.musicV;
        
        for (int i = 0; i < MejoresPuntajes.Length; i++)
        {

            MejoresPuntajes[i] = player.MejoresPuntajes[i];

        }


    }
}
