using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheating : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Coins.coins++;
            Debug.Log("Coins: " + Coins.coins);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Coins.coins = Coins.coins + 10;
            Debug.Log("Coins: " + Coins.coins);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            GameObject.Find("Countdown").GetComponent<RaceCountdown>().minute++;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject.Find("Countdown").GetComponent<RaceCountdown>().minute--;
        }
    }
}
