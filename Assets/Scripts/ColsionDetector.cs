using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColsionDetector : MonoBehaviour
{
    [SerializeField] GameObject pojar;
    [SerializeField] GameObject stolik;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stoll")
        {
            pojar = GameObject.FindWithTag("Fire");
            Destroy(pojar);
            Destroy(gameObject);
        }


    }
}
