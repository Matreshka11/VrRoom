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

    private void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        Sound.SetActive(false);
    }

    public void Update()
    {
        GoldCount.text = _goldCount.ToString();
        RubbishCount.text = _rubbishCount.ToString();
        if (_rubbishCount == 0 && _goldCount == 0)
        {
            Timer += Time.deltaTime;
            Anim.SetBool("isStart", true);
            if (Timer >= 17.3f)
            {
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
