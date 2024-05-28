using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class cabezaColl : MonoBehaviour
{


    public bool enCollicion = false;
    public comidaspawner comidaspawner;
    public Player player;
    public snake snake;
    public cola cola;
    public Puntaje Puntaje;
    public particulas particulas;
    public sonidoComida sonidoComida;




    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "comida")
        {

            comidaspawner.ComidaSpawn();
            cola.lenght++;
            cola.valorCrecimiento = 1;
            Puntaje.sumarPuntos(1);
            particulas.cargarParticulas(1);
            snake.Speed -= 0.1f;
            sonidoComida.comidaSonido();


        }

        if (collision.collider.tag == "comidax2")
        {

            cola.lenght += 2;
            cola.valorCrecimiento = 2;
            Puntaje.sumarPuntos(2);
            particulas.cargarParticulas(2);
            snake.Speed -= 0.2f;
            sonidoComida.comidaSonido();

        }
         if (collision.collider.tag == "comidax5")
        {

            cola.lenght += 5;
            cola.valorCrecimiento = 5;
            Puntaje.sumarPuntos(5);
            particulas.cargarParticulas(3);
            snake.Speed -= 0.5f;
            sonidoComida.comidaSonido();

        }

        if (collision.collider.tag == "muro")
        {

            snake.destoyOB();
            Puntaje.guardarpuntos();
            saveManager.SavePlayerData(player);
            Debug.Log("datos guardados");
        }
        if (collision.collider.tag == "cola")
        {

            snake.destoyOB();
            Puntaje.guardarpuntos();
            saveManager.SavePlayerData(player);
            Debug.Log("datos guardados");
        }




    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (enCollicion == true)
        {
            enCollicion = false;
        }
    }
}
