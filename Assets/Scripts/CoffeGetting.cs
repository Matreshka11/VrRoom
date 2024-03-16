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
    void Start()
    {
        Door.SetActive(false);
        Pojarr.SetActive(false);
    }


    public void OnLaverEnter()
    {
        Door.SetActive(true);
        Instantiate(CoffeCup, new Vector3(4.5f, 0.5f, 4.2f), Quaternion.identity);
    }
    public void OnlaverExit()
    {
        Door.SetActive(false);
        Pojarr.SetActive(true);
        DoorKill.SetActive(false);
        scriptActivator.SetActive(false);
    }
}