using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceCountdown : MonoBehaviour
{
    public float countdown = 3.49f;
    public float currentTime = 0f;
    void Start()
    {
        currentTime = countdown;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            this.GetComponent<Text>().text = currentTime.ToString("0");

            //if (currentTime <= 1f) { this.GetComponent<Text>().color = Color.red; }
        }

        if (currentTime <= 0.5f)
        {
            this.GetComponent<Text>().text = "GO!";
            currentTime -= 1 * Time.deltaTime;
            if(currentTime <= -2f)
            {
                this.GetComponent<Text>().text = "";
            }
            /*
            car.GetComponent<AudioSource>().Stop();
            gameOverUI.SetActive(true);
            gamePlayUI.SetActive(false);
            PlayerCar.isPlaying = false;
            //play game over sound
            */
        }
    }
}
