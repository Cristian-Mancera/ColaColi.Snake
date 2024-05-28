using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class comida : MonoBehaviour
{

   



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "cabezaColl")
        {
            
            Destroy(gameObject);
            

        }

    }




}
