using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGoldcontroller : MonoBehaviour
{
    private int _goldCount = 2;
    private int _rubbishCount = 1;
    public Text GoldCount;
    public Text RubbishCount;
    public Animator Anim;
    float Timer = 0;
    public GameObject Sound;
    public GameObject Wheel1;
    public GameObject Wheel2;
    public GameObject Wheel3;
    public GameObject Wheel4;
    public GameObject Wheel5;
    public GameObject Wheel6;
    public GameObject WheelsSound;
    public GameObject WithoutCar;

    private void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        Sound.SetActive(false);
        WheelsSound.SetActive(false);
        WithoutCar.SetActive(false);
    }
    private void Wheels()
    {
        Wheel1.transform.Rotate(0, 0, -0.5f);
        Wheel2.transform.Rotate(0, 0, -0.5f);
        Wheel3.transform.Rotate(0, 0, -0.5f);
        Wheel4.transform.Rotate(0, 0, 0.5f);
        Wheel5.transform.Rotate(0, 0, 0.5f);
        Wheel6.transform.Rotate(0, 0, 0.5f);
    }
    public void Update()
    {
        GoldCount.text = _goldCount.ToString();
        RubbishCount.text = _rubbishCount.ToString();
        if (_rubbishCount == 0 && _goldCount == 0)
        {
            Timer += Time.deltaTime;
            Anim.SetBool("isStart", true);
            Wheels();
            WheelsSound.SetActive(true);
            if (Timer >= 17.3f)
            {
                WithoutCar.SetActive(true);
                WheelsSound.SetActive(false);
                gameObject.SetActive(false);
            }
        }
        if (_goldCount == 1)
        {
            Sound.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gold")
        {

            if (_goldCount == 0)
            {
                _goldCount = 0;
            }
            else
            {
                _goldCount -= 1;
            }
        }
        if (collision.gameObject.tag == "Rubbish")
        {

            if (_rubbishCount == 0)
            {
                _rubbishCount = 0;
            }
            else
            {
                _rubbishCount -= 1;
            }
            
        }
        
    }

}
