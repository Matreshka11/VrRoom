using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHouseActivated : MonoBehaviour
{
    public GameObject VoiceOfActivation;
    public GameObject Door;
    public GameObject SoundDoorOpened;
    private bool keyActive = false;

    private void Start()
    {
        VoiceOfActivation.SetActive(false);
        SoundDoorOpened.SetActive(false);
    }
    public void OnBattaryPlaced()
    {
        keyActive = true;
        Destroy(Door);
        SoundDoorOpened.SetActive(keyActive);
        VoiceOfActivation.SetActive(keyActive);
        //Debug.Log(VoiceOfActivation.activeSelf);
    }

}
