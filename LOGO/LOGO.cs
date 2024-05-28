using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOGO : MonoBehaviour
{

    [SerializeField]
    Animator trancisionAnim;
    public float timer;
    void Update()
    {

        for (int i = 0; timer < 21; i++)
        {

            timer += 0.5f;

            if (timer == 20)
            {
                int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
                if (sceneBuildIndex == 0)
                {
                    StartCoroutine(ChangeSceneA());

                }
                else
                {
                    StartCoroutine(ChangeSceneB());

                }


            }
        }



    }

    IEnumerator ChangeSceneA()
    {

        yield return new WaitForSeconds(2f);
        trancisionAnim.SetBool("logo", true);
        StartCoroutine(ChangeSceneB());
    }

    IEnumerator ChangeSceneB()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(1);
    }
}
