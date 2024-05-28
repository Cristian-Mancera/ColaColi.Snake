using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MENU : MonoBehaviour
{

    public Image imagen1;
    public Image imagen2;
    public Image imagen3;
    public Image imagen4;
    public indicador indicador;

   
    
    

    bool Casa = false;
    bool Perf = false;
    bool Pers = false;
    bool Confg = false;


    void Start()
    {

    }


    void Update()
    {

        if (Casa)
        {
            imagen1.GetComponent<Image>().color = new Color32(46, 59, 106, 225);
            imagen3.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen2.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen4.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            indicador.definir_Posicion(1);
            Casa = false;
           

        }
         if (Perf)
        {
            imagen2.GetComponent<Image>().color = new Color32(46, 59, 106, 225);
            imagen1.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen3.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen4.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            indicador.definir_Posicion(2);
            Perf = false;
            
            
            

        }
         if (Pers)
        {
            imagen3.GetComponent<Image>().color = new Color32(46, 59, 106, 225);
            imagen1.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen2.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen4.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            indicador.definir_Posicion(3);
            Pers = false;
            

        }
         if (Confg)
        {
            imagen4.GetComponent<Image>().color = new Color32(46, 59, 106, 225);
            imagen1.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen2.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            imagen3.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            indicador.definir_Posicion(4);
            Confg = false;
            

        }

    }


    public void CasaT()
    {


        Casa = true;

    }
    public void PerfilT()
    {


        Perf = true;

    }
    public void PersT()
    {

        Pers = true;


    }
    public void ConfigT()
    {


        Confg = true;

    }


}
