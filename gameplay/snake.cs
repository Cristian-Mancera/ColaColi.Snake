using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class snake : MonoBehaviour
{


    public cabezaColl cabezaColl;
    public gameOver gameOver;
    public ParticleSystem particulas;
    public Sprite skinG;
    public Sprite skinB;
    public Sprite skinR;
    public Sprite skinD;


    bool up = false;
    bool down = false;
    bool left = false;
    bool right = false;
    int MovInd;
    private Vector3 direccion;
    public float Speed;

    public void Start()
    {

        MovInd = 5;
    }

    public void ClickUp()
    {

        up = true;
    }
    public void ReleaseUp()
    {

        up = false;
    }
    public void ClickDown()
    {

        down = true;
    }
    public void ReleaseDown()
    {

        down = false;
    }
    public void ClickLeft()
    {

        left = true;
    }
    public void ReleaseLeft()
    {

        left = false;
    }
    public void ClickRight()
    {

        right = true;
    }
    public void ReleaseRight()
    {

        right = false;
    }


    private void FixedUpdate()
    {



        if (Input.GetKey("w"))
        {
            MovInd = 3;
        }
        if (Input.GetKey("a"))
        {
            MovInd = 1;
        }
        if (Input.GetKey("s"))
        {
            MovInd = 2;
        }
        if (Input.GetKey("d"))
        {
            MovInd = 0;
        }


        if (MovInd != 2)
        {
            if (up)
            {
                MovInd = 3;
            }
        }
        if (MovInd != 3)
        {
            if (down)
            {
                MovInd = 2;
            }
        }
        if (MovInd != 0)
        {
            if (left)
            {
                MovInd = 1;
            }
        }
        if (MovInd != 1)
        {
            if (right)
            {
                MovInd = 0;
            }
        }



        if (MovInd == 5)
        {
            gameObject.transform.Translate(-1f * Time.deltaTime, 0, 0);
            particulas.Play();

        }



        if (MovInd == 0)
        {
            gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.left);
            gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
            particulas.Play();
        }

        if (MovInd == 1)
        {
            gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.right);
            gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
            particulas.Play();
        }

        if (MovInd == 2)
        {
            gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.up);
            gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
            particulas.Play();
        }
        if (MovInd == 3)
        {
            gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.down);
            gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
            particulas.Play();
        }




    }

    public void destoyOB()
    {

        Destroy(gameObject);
        gameOver.resetBoton();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {







    }


}
