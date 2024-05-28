using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Nskin;
    public float puntajeGlobal;
    public int musicV;
    public float nivel;
    public float exp;
    public bool DarkScreen;
    public float[] MejoresPuntajes = new float[5];

    public void guardarPuntaje(float puntaje)
    {

        for (int i = 0; i < MejoresPuntajes.Length; i++)
        {

            if (MejoresPuntajes[i] <= puntaje)
            {


                for (int j = 4; j > i; j--)
                {

                    MejoresPuntajes[j] = MejoresPuntajes[j - 1];

                }
                MejoresPuntajes[i] = puntaje;

                i = MejoresPuntajes.Length;
            }
            // else if (MejoresPuntajes[i] >= puntaje)
            // {

            //   MejoresPuntajes[i] = MejoresPuntajes[i];
            //}

        }

        puntajeGlobal = puntajeGlobal + (puntaje * 0.2f);

        if (exp <= 100)
        {

            if (puntajeGlobal <= 100)
            {

                exp = exp + puntajeGlobal * 0.3f;

            }
            if (puntajeGlobal <= 1000 && puntajeGlobal >= 101)
            {

                exp = exp + (puntajeGlobal / 10) * 0.3f;

            }
            if (puntajeGlobal <= 10000 && puntajeGlobal >= 1001)
            {

                exp = exp + (puntajeGlobal / 100) * 0.3f;

            }


        }

        if (exp > 100)
        {

            nivel += 1;
            exp = 0;
        }


    }

}
