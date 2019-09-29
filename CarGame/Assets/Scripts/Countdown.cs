using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gamePlayUI;
    public GameObject car;
    public float countdown = 20f;
    public float currentTime = 0f;
    public Text countdownText;

    void Start()
    {
        currentTime = countdown;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime >= 0)
        {
            countdownText.color = Color.white;
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if(currentTime <= 5f) { countdownText.color = Color.red; }
        }

        if(currentTime <= 0)
        {
            car.GetComponent<AudioSource>().Stop();
            gameOverUI.SetActive(true);
            gamePlayUI.SetActive(false);
            PlayerCar.isPlaying = false;
            //play game over sound
        } 
    }
}
