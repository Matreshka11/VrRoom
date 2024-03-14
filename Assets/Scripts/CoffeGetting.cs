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
    public Animator Anim;
    void Start()
    {
        Pojarr.SetActive(false);
        Anim = Door.GetComponent<Animator>();
    }


    public void OnLaverEnter()
    {
        Debug.Log(1);
        scriptActivator.SetActive(true);
        Anim.SetBool("isOpen", false);
        
    }
    public void OnlaverExit()
    {
        Anim.SetBool("isOpen", true);
    }

}
