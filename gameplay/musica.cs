using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{

    public AudioSource music;

    public Player player;



    void Update()
    {
        music.volume = player.musicV;

    }


}
