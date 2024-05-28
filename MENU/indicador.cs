using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicador : MonoBehaviour
{



    public void definir_Posicion(int Posc)
    {

        if (Posc == 1)
        {

            gameObject.transform.position = new Vector3(-1.739f, 3.889f, 0f);

        }
        if (Posc == 2)
        {

            gameObject.transform.position = new Vector3(-0.595f, 3.889f, 0f);

        }
        if (Posc == 3)
        {

            gameObject.transform.position = new Vector3(0.516f, 3.889f, 0f);

        }
        if (Posc == 4)
        {

            gameObject.transform.position = new Vector3(1.727f, 3.889f, 0f);

        }


    }
}
