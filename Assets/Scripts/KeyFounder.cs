using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFounder : MonoBehaviour
{
    [SerializeField]GameObject Card;
    [SerializeField] Animator Controll;
    public GameObject Sound;
    public GameObject CallSound;
    public GameObject Door;
    private float _timer = 0;
    private void Start()
    {
        Sound.SetActive(false);

    }
    public void OnButtonPushed()
    {
        Sound.SetActive(true);
        Destroy(Door);
    }
}
