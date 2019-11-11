﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject countdownObj;
    public GameObject finishedUI;
    public GameObject gamePlayUI;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("finished!");
            countdownObj.GetComponent<RaceCountdown>().gameFinished = true;
            GameObject.Find("Car1").GetComponent<AudioSource>().Stop();
            GameObject.Find("Main Camera").GetComponent<CameraFollow>().cameraHeight = 30f;
            PlayerCar.isPlaying = false;
            finishedUI.SetActive(true);
            gamePlayUI.SetActive(false);
            countdownObj.GetComponent<RaceCountdown>().FinishedTime();
            GameObject.Find("DefaultCoin").GetComponent<Coins>().SetCoins(); 
        }
    }
}