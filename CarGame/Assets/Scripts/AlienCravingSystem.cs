using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class AlienCravingSystem : MonoBehaviour
{
    private int extraTime = 6;
    public Text alienMessageText;
    public string[] messages;
    static Random rnd = new Random();

    [HideInInspector] public bool cravingMet = false;

    //int randomNumber;
    public Countdown countDown;
    public GameMan gameManager;
    public Text GameoverScoreText;
    public Text scoreText;
    public static int rnum;
    AudioSource scoreSource;
    //[HideInInspector] public bool isFirstLevels = true;
    private static int level;

    void Start()
    {
        scoreSource = GetComponent<AudioSource>();
        PickCraving(0, 0);
        level = 1;
    }

    void PickCraving(int lowerbound, int higherbound)
    {
        int randomNumber = Random.Range(lowerbound, higherbound); //number of easy cravings
        rnum = randomNumber;
        Debug.Log("Case: " + randomNumber);
        alienMessageText.text = "Alien says he wants:\n" + messages[randomNumber];
    }

    void Update()
    {
        ////for debugging
        if (Input.GetKeyDown(KeyCode.T))
        {
            countDown.currentTime += extraTime;
        }
        ////
        scoreText.text = "SCORE: " + GameMan.score.ToString();

        if (cravingMet)
        {
            countDown.currentTime += extraTime;

            switch (level)
            {
                case 0: //Level 1 (level 0)
                    PickCraving(0, 0); //0,0
                    //level++;
                    break;
                case 1: 
                case 2:
                case 3: //Level 2 (level 1-3)
                    PickCraving(1, 5); //1,5
                    level++;
                    break;
                case 4: //Level 3 (level 4)
                    PickCraving(6, 6); // 6,6
                    level++;
                    break;
                case 5: 
                case 6:
                case 7: //Level 4 (level 5-7)
                    PickCraving(7, 11); //7,11
                    //countDown.currentTime += (extraTime / 2); //give more time on different levels
                    level++;
                    break;
                case 8:
                case 9:
                case 10: //Level 5 (level 8-10)
                    PickCraving(12, 16); //12, 16
                    //countDown.currentTime += (extraTime);
                    level++;
                    break;
                default:
                    PickCraving(0 , 16); //0, 16
                    //countDown.currentTime += (extraTime);
                    level++;
                    break;
            }

            GameMan.score += 10;
            scoreSource.Play();
            Debug.Log("Score: " + GameMan.score);
            GameoverScoreText.text = "Score: " + GameMan.score.ToString();
            cravingMet = false;
        }
    }
}
