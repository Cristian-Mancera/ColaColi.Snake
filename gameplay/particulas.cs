using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particulas : MonoBehaviour
{



    public snake snake;
    public ParticleSystem particulas1;
    public ParticleSystem particulas2;
    public ParticleSystem particulas3;


    private void Start()
    {


        particulas1.Stop();
        particulas2.Stop();
        particulas3.Stop();
    }
    public void cargarParticulas(int x)
    {
        gameObject.transform.position = snake.transform.position;
        if (x == 1)
        {
            particulas1.Play();

        }
        if (x == 2)
        {
            particulas2.Play();

        }
         if (x == 3)
        {
            particulas3.Play();

        }




    }
}
