using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject gamePlayUI;
    public GameObject arms;

    public void PlayButton()
    {
        CameraFollow.isPlaying = true;
        //PlayerCar.isPlaying = true;
        gamePlayUI.SetActive(true);
        startMenuUI.SetActive(false);
        arms.SetActive(true);
        Debug.Log("Play");
    }
    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();

    }

    //retry button in the GameOver screen
    public void RetryButton()
    {
        Debug.Log("Retry");
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}
