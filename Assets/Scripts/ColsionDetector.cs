using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColsionDetector : MonoBehaviour
{
    public GameObject pojar;
    public GameObject stolik;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stoll")
        {
            Destroy(pojar);
            Destroy(stolik);
            Destroy(gameObject);
        }


    }
}
