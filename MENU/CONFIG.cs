using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CONFIG : MonoBehaviour
{
    [SerializeField]
    public AudioSource musica;

    [SerializeField]
    Animator animacion;
    [SerializeField]
    Animator animacion2;
    public Renderer fondo;
    public Renderer fondo1;
    public Image fondo3;
    public Image fondo4;
    public Image fondo2;
    public Image fondo5;

    public Image tx1;
    public Image tx2;
    public Image tx3;
    public Image tx4;
    public Image tx5;

    public Player player;
    public bool Dark;


    public void Start()
    {
        Dark = player.DarkScreen;
        musica.volume = player.musicV;
        Debug.Log(Dark);
        if (Dark == true)
        {
            animacion.SetBool("activacion", true);

        }
        if (Dark == false)
        {
            animacion.SetBool("activacion", false);

        }


    }
    public void darkBT()
    {

        if (Dark == true)
        {
            animacion.SetBool("activacion", false);
            Dark = false;
            player.DarkScreen = false;
            saveManager.SavePlayerData(player);
            Debug.Log("datos guardados");
        }
        else
        {
            animacion.SetBool("activacion", true);
            Dark = true;
            player.DarkScreen = true;
            saveManager.SavePlayerData(player);
            Debug.Log("datos guardados");
        }




    }



    public void Update()
    {



        ChangeTheme();






    }

    public void ChangeTheme()
    {

        if (Dark == true)
        {

            fondo.GetComponent<SpriteRenderer>().color = new Color32(80, 80, 80, 255);
            fondo1.GetComponent<SpriteRenderer>().color = new Color32(60, 60, 60, 255);
            fondo4.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            fondo3.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            fondo2.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            fondo5.GetComponent<Image>().color = new Color32(70, 70, 70, 255);

            tx1.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            tx2.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            tx3.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            tx4.GetComponent<Image>().color = new Color32(70, 70, 70, 255);
            tx5.GetComponent<Image>().color = new Color32(70, 70, 70, 255);

        }
        if (Dark == false)
        {

            fondo.GetComponent<SpriteRenderer>().color = new Color32(225, 225, 225, 255);
            fondo1.GetComponent<SpriteRenderer>().color = new Color32(214, 214, 214, 255);
            fondo4.GetComponent<Image>().color = new Color32(220, 220, 220, 255);
            fondo3.GetComponent<Image>().color = new Color32(220, 220, 220, 255);
            fondo2.GetComponent<Image>().color = new Color32(220, 220, 220, 255);
            fondo5.GetComponent<Image>().color = new Color32(220, 220, 220, 255);

            tx1.GetComponent<Image>().color = new Color32(220, 220, 220, 255);
            tx2.GetComponent<Image>().color = new Color32(220, 220, 220, 255);
            tx3.GetComponent<Image>().color = new Color32(220, 220, 220, 255);
            tx4.GetComponent<Image>().color = new Color32(220, 220, 220, 255);
            tx5.GetComponent<Image>().color = new Color32(220, 220, 220, 255);


        }

    }

    public void music()
    {
        if (musica.volume == 0)
        {
            musica.volume = 1;

            animacion2.SetBool("music", true);
            player.musicV = 1;
            saveManager.SavePlayerData(player);
            Debug.Log("datos guardados");

        }
        else
        {
            musica.volume = 0;

            animacion2.SetBool("music", false);
            player.musicV = 0;
            saveManager.SavePlayerData(player);
            Debug.Log("datos guardados");

        }



    }


}
