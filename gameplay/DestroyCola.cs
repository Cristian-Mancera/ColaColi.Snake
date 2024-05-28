using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCola : MonoBehaviour
{

    public void Destruir(int a)
    {
        Destroy(this);
    }

    public void desaparecer()
    {

        gameObject.SetActive(false);

    }
}
