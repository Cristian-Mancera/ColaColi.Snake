using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{
    public CONFIG cONFIG;
    public Player player;

    [SerializeField]
    Animator animacion;

    public void Update()
    {
        cONFIG.musica.volume = player.musicV;
        cONFIG.Dark = player.DarkScreen;
        cONFIG.ChangeTheme();


    }
    public void Play()
    {
        saveManager.SavePlayerData(player);
        Debug.Log("datos guardados");
        animacion.SetBool("salida", true);
        StartCoroutine("salida");



    }

    public IEnumerator salida()
    {

        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene("COLACOLI1.1");
    }
}
