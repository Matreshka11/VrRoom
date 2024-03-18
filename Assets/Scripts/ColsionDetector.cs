using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColsionDetector : MonoBehaviour
{
    [SerializeField] GameObject pojar;
    [SerializeField] GameObject stolik;
    public GameObject CallSound;
    private void Start()
    {
        CallSound = GameObject.FindWithTag("Sound");
        CallSound.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stoll")
        {
            //pojar = GameObject.FindWithTag("Fire");
            CallSound.SetActive(true);
            Destroy(pojar);
            Destroy(gameObject);
        }


    }
}
