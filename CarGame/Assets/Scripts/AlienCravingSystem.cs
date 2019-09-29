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
        LevelOnePickCraving();
        level = 1;
    }

    void LevelOnePickCraving()
    {
        int randomNumber = Random.Range(0, 0); //number of easy cravings
        rnum = randomNumber;
        Debug.Log("Level 1 case: " + randomNumber);
        alienMessageText.text = "Alien says he wants:\n" + messages[randomNumber];
    }

    void LevelTwoPickCraving()
    {
        int randomNumber = Random.Range(1, 5); //level two range
        rnum = randomNumber;
        Debug.Log("Level 2 case: " + randomNumber);
        alienMessageText.text = "Alien says he wants:\n" + messages[randomNumber];
    }
    void LevelThreePickCraving()
    {
        int randomNumber = Random.Range(6, 6); //level three range
        rnum = randomNumber;
        Debug.Log("Level 3 case: " + randomNumber);
        alienMessageText.text = "Alien says he wants:\n" + messages[randomNumber];
    }
    void LevelFourPickCraving()
    {
        int randomNumber = Random.Range(7, 11); // level four range
        rnum = randomNumber;
        Debug.Log("Level 3 case: " + randomNumber);
        alienMessageText.text = "Alien says he wants:\n" + messages[randomNumber];
    }
    void LevelFivePickCraving()
    {
        int randomNumber = Random.Range(12, 16); //level five range
        rnum = randomNumber;
        Debug.Log("Level 3 case: " + randomNumber);
        alienMessageText.text = "Alien says he wants:\n" + messages[randomNumber];
    }
    void PickAnyCraving()
    {
        int randomNumber = Random.Range(0, 16); //level five range
        rnum = randomNumber;
        Debug.Log("Level 3 case: " + randomNumber);
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
                    LevelOnePickCraving();
                    //level++;
                    break;
                case 1: 
                case 2:
                case 3: //Level 2 (level 1-3)
                    LevelTwoPickCraving();
                    level++;
                    break;
                case 4: //Level 3 (level 4)
                    LevelThreePickCraving();
                    level++;
                    break;
                case 5: 
                case 6:
                case 7: //Level 4 (level 5-7)
                    LevelFourPickCraving();
                    //countDown.currentTime += (extraTime / 2); //give more time on different levels
                    level++;
                    break;
                case 8:
                case 9:
                case 10: //Level 5 (level 8-10)
                    LevelFivePickCraving();
                    //countDown.currentTime += (extraTime);
                    level++;
                    break;
                default:
                    PickAnyCraving();
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
