using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollisionChecker : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Robot")
        {
            Destroy(gameObject);
        }
    }

}
