using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSkin : MonoBehaviour
{

    public snake snake;
    public int Nskin;
    public Sprite skinG;
    public Sprite skinB;
    public Sprite skinR;
    public Sprite skinD;
    public void Skin(int x)
    {
        Nskin = x;

        if (x == 1)
        {
            snake.GetComponent<SpriteRenderer>().sprite = skinG;
        }
        if (x == 2)
        {
            snake.GetComponent<SpriteRenderer>().sprite = skinB;
        }
        if (x == 3)
        {
            snake.GetComponent<SpriteRenderer>().sprite = skinR;
        }
        if (x == 4)
        {
            snake.GetComponent<SpriteRenderer>().sprite = skinD;
        }



    }

}
