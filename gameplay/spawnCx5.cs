using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCx5 : MonoBehaviour
{
    public GameObject comidaPrefav;

    public float valorR;
    public float Timer = 5f;


    void Update()
    {

        valorR = Random.Range(0f, 50.0f);
        if (valorR <= 0.01)
        {


            ComidaSpawn();

        }

    }


    public void ComidaSpawn()
    {

        float x = Random.Range(10f, -10f);
        float y = Random.Range(10f, -10f);
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotacion = new Quaternion();

        Instantiate(comidaPrefav, position, rotacion);




    }
}
