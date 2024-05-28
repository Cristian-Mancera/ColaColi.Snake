using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    [SerializeField]
    Animator animacion;

    public void resetScene()
    {


        SceneManager.LoadScene("COLACOLI1.1");




    }

    public void CASAScene()
    {
        if(Time.timeScale == 0){
            Time.timeScale = 1f;
        }
        animacion.SetBool("salida", true);
        StartCoroutine("salida");

    }


    public IEnumerator salida()
    {



        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MENU_PRINCIPAL");

    }



}
