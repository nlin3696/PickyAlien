using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMan : MonoBehaviour
{
    public static int score;
    static int highscore;
    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highscoreText.text = "HIGHSCORE\n" + 
            PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highscore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highscore = score;
            Debug.Log("New highscore: " + highscore);
            PlayerPrefs.Save();


        }
    }
}
