
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cola : MonoBehaviour
{
    public Player player;
    public int lenght = 2;
    public int TipoCola = 1;
    public GameObject colaPrefab;
    public GameObject colaPrefabB;
    public GameObject colaPrefabR;
    public GameObject colaPrefabD;
    public cabezaColl cabezaColl;
    public int valorCrecimiento;
    public int DestVAL = 0;
    public LineRenderer linerender;
    public Vector3[] segmenposes;
    public Vector3[] segmentV;
    public Vector3[] ValUltPos;
    public Vector3 posCola;
    public Transform wiggleDir;
    public float wiggleSpeed;
    public float wiggleMagnitude;
    public int ultiPos;
    public Transform targetDir;
    public float targetDist;
    public float smothSpeed;
    public float trailSpeed;
    public int tamañoCol;

    public GameObject[] bodyparts;








    private void Start()
    {
        TipoCola = player.Nskin;
        ValUltPos = new Vector3[lenght + 5];

        tamCola(lenght, TipoCola);
        tamañoCol = lenght;

        resetPos();


    }

    private void Update()
    {

        segmenposes[0] = targetDir.position;
        if (lenght == tamañoCol)
        {
            movCola();

        }

        if (lenght != tamañoCol)
        {
            tamCola(lenght, TipoCola);

            for (int i = 0; i < segmenposes.Length - 1; i++)
            {

                segmenposes[i] = ValUltPos[i];
            }

            if (valorCrecimiento == 1)
            {
                segmenposes[lenght - 1] = posCola;
                valorCrecimiento = 0;

            }
            if (valorCrecimiento == 2)
            {
                segmenposes[lenght - 2] = posCola;
                posCola.z -= 1;
                segmenposes[lenght - 1] = posCola;

                valorCrecimiento = 0;

            }
            if (valorCrecimiento == 3)
            {
                segmenposes[lenght - 3] = posCola;
                posCola.z -= 1;
                segmenposes[lenght - 2] = posCola;
                posCola.z -= 1;
                segmenposes[lenght - 1] = posCola;
                valorCrecimiento = 0;

            }
            if (valorCrecimiento == 5)
            {
                segmenposes[lenght - 5] = posCola;
                posCola.z -= 1;
                segmenposes[lenght - 4] = posCola;
                posCola.z -= 1;
                segmenposes[lenght - 3] = posCola;
                posCola.z -= 1;
                segmenposes[lenght - 2] = posCola;
                posCola.z -= 1;
                segmenposes[lenght - 1] = posCola;
                valorCrecimiento = 0;

            }



            ValUltPos = new Vector3[lenght + 5];



            tamañoCol = lenght;

        }
        for (int i = 0; i < segmenposes.Length; i++)
        {
            ValUltPos[i] = segmenposes[i];
        }
        posCola = segmenposes[lenght - 1];




    }



    public void tamCola(int lenght, int TipoCola)
    {

        if (DestVAL == 1)
        {

            for (int i = 0; i < bodyparts.Length - 1; i++)
            {
                Destroy(GameObject.Find("cola" + i));
            }
            DestVAL = 0;

        }
        linerender.positionCount = lenght;
        linerender.SetPosition(lenght - 1, posCola);


        //arreglo que guarde los valores de la cola o un for que recorra la cola y le ponga la misma posicion :(

        Debug.Log("cola creada");
        segmenposes = new Vector3[lenght];
        bodyparts = new GameObject[segmenposes.Length + 5];

        if (TipoCola == 0)
        {

            TipoCola = player.Nskin;
        }

        if (TipoCola == 1)
        {
            for (int i = 0; i < bodyparts.Length - 1; i++)
            {

                bodyparts[i] = Instantiate(colaPrefab);
                bodyparts[i].name = "cola" + i;
                DestVAL = 1;

            }
        }
        if (TipoCola == 2)
        {
            for (int i = 0; i < bodyparts.Length - 1; i++)
            {

                bodyparts[i] = Instantiate(colaPrefabB);
                bodyparts[i].name = "cola" + i;
                DestVAL = 1;

            }
        }
        if (TipoCola == 3)
        {
            for (int i = 0; i < bodyparts.Length - 1; i++)
            {

                bodyparts[i] = Instantiate(colaPrefabR);
                bodyparts[i].name = "cola" + i;
                DestVAL = 1;

            }
        }
        if (TipoCola == 4)
        {
            for (int i = 0; i < bodyparts.Length - 1; i++)
            {

                bodyparts[i] = Instantiate(colaPrefabD);
                bodyparts[i].name = "cola" + i;
                DestVAL = 1;

            }
        }





        segmentV = new Vector3[lenght];
        linerender = this.GetComponent<LineRenderer>();


    }


    public void movCola()
    {


        wiggleDir.localRotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time * wiggleSpeed) * wiggleMagnitude);



        for (int i = 1; i < segmenposes.Length; i++)
        {

            Vector3 targetPos = segmenposes[i - 1] + (segmenposes[i] - segmenposes[i - 1]).normalized * targetDist;
            segmenposes[i] = Vector3.SmoothDamp(segmenposes[i], targetPos, ref segmentV[i], smothSpeed);
            bodyparts[i - 1].transform.position = segmenposes[i];
        }

        linerender.SetPositions(segmenposes);


    }

    public void resetPos()
    {
        for (int i = 1; i < lenght; i++)
        {
            segmenposes[i] = segmenposes[i - 1] + targetDir.right * targetDist;

        }
        linerender.SetPositions(segmenposes);

    }










}
