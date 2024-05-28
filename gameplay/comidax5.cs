using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class comidax5 : MonoBehaviour
{


    private void Start()
    {

        StartCoroutine("tiempoDestroy");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "cabezaColl")
        {

            Destroy(gameObject);


        }


    }

    public IEnumerator tiempoDestroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }


}
