using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class comidaspawner : MonoBehaviour
{


    public GameObject comidaPrefav;



    public void ComidaSpawn()
    {

        float x = Random.Range(10f, -10f);
        float y = Random.Range(10f, -10f);
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotacion = new Quaternion();

        Instantiate(comidaPrefav, position, rotacion);




    }

}




