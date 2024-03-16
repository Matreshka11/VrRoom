using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightregulation : MonoBehaviour
{
    private bool _lightStatus;
    public GameObject LightofScene;
    private Light _light;
    void Start()
    {
        _lightStatus = true;
        _light = LightofScene.GetComponent<Light>();
    }

    // Update is called once per frame
    public void OnClick()
    {
        if (_lightStatus == true)
        {
            _light.enabled = false;
            _lightStatus = false;
        }
        else
        {
            _light.enabled = true;
            _lightStatus = true;
        }
        Debug.Log(_lightStatus);
    }
}
