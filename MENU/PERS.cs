using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PERS : MonoBehaviour
{
    public Player player;
    public bool skinG;
    public bool skinB;
    public bool skinR;
    public bool skinD;
    public Button botonB;
    public Button botonR;
    public Button botonD;


    public void Update()
    {
        DesblSkin();
    }

    public void DesblSkin()
    {


        if (player.nivel >= 3)
        {
            botonB.interactable = true;
        }
        if (player.nivel >= 6)
        {
            botonR.interactable = true;
        }
        if (player.nivel >= 8)
        {
            botonD.interactable = true;
        }


    }

    public void skinGC()
    {

        skinG = true;
        skinB = false;
        skinR = false;
        skinD = false;
        Skin();
    }
    public void skinBC()
    {

        skinG = false;
        skinB = true;
        skinR = false;
        skinD = false;
        Skin();
    }
    public void skinRC()
    {

        skinG = false;
        skinB = false;
        skinR = true;
        skinD = false;
        Skin();
    }
    public void skinDC()
    {

        skinG = false;
        skinB = false;
        skinR = false;
        skinD = true;
        Skin();
    }



    public void Skin()
    {

        if (skinG)
        {
            player.Nskin = 1;

        }
        if (skinB)
        {
            player.Nskin = 2;

        }
        if (skinR)
        {
            player.Nskin = 3;

        }
        if (skinD)
        {
            player.Nskin = 4;

        }
        saveManager.SavePlayerData(player);
        Debug.Log("datos guardados");


    }
}
