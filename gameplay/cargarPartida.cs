using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarPartida : MonoBehaviour
{

    public Player player;
    public PlayerData PlayerData;
    public SelectorSkin selectorSkin;


    void Start()
    {
        PlayerData playerData = saveManager.loadPlayerData();
        player.Nskin = playerData.Nskin;
        player.puntajeGlobal = playerData.Puntaje_Global;
        player.exp = playerData.exp;
        player.nivel = playerData.nivel;
        player.DarkScreen = playerData.DarkScreen;
        player.musicV = playerData.musicV;
        for (int i = 0; i < player.MejoresPuntajes.Length; i++)
        {
            player.MejoresPuntajes[i] = playerData.MejoresPuntajes[i];
        }
       
        selectorSkin.Skin(player.Nskin);


        Debug.Log("partida cargada");
    }



}
