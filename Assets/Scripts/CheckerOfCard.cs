using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerOfCard : MonoBehaviour
{
    private Animator _anim;
    public GameObject Door;
    public GameObject MainDoor;
    private void Start()
    {
        _anim = Door.GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Key"))
        {
            _anim.SetBool("isReady", true);
            Destroy(MainDoor);
        }
    }
}
