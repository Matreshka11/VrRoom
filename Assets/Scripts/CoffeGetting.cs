using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeGetting : MonoBehaviour
{
    public GameObject Door;
    public GameObject DoorKill;
    public GameObject CoffeCup;
    public GameObject Pojarr;
    public GameObject scriptActivator;
    private Animator _anim;
    public GameObject SoundOfCall;
    private int Count = 0;
    void Awake()
    {
        Pojarr.SetActive(false);
        SoundOfCall.SetActive(false);
    }


    public void OnLaverEnter()
    {
        //Instantiate(CoffeCup, new Vector3(3.56f,0.41f,3.3f), Quaternion.identity);
            Count += 1;
            if (Count == 1)
            {
            //scriptActivator.SetActive(true);
            SoundOfCall.SetActive(true);
            }
        Door.SetActive(false);
        DoorKill.SetActive(false);

        

    }
    public void OnlaverExit()
    {
        Door.SetActive(true);

    }
}