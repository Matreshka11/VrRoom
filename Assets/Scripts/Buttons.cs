using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject music;
    private bool MusicFlag = true;

    private void Update()
    {
        if (MusicFlag == true) 
        {
            music.SetActive(MusicFlag);
        }
        else
        {
            music.SetActive(false);
        }
    }
    public void StopMusic()
    {
        Debug.Log("Clicked");
        if (MusicFlag == true)
        {
            MusicFlag = false;
        }
        else
        {
            MusicFlag = true;
        }
        Debug.Log(MusicFlag);
    }
}
