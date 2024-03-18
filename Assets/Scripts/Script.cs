using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Script : MonoBehaviour
{
    private float timeer = 0;
    public GameObject pojar;
    public GameObject door;
    void Start()
    {
        gameObject.SetActive(false);  
    }
    void Update()
    {
        timeer += Time.deltaTime;
        if(timeer > 5) 
        {
            door.SetActive(false);
        }
    }
}
