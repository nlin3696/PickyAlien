using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for course select
using UnityEngine.UI;

public class CarAI : MonoBehaviour
{
    bool startedAnim;
    Animator anim;
    public AnimationClip easyAI;
    public AnimationClip mediumAI;
    public AnimationClip hardAI;
    public AnimationClip proAI;
    string clip;

    // for course select
    public GameObject playButton;

    Animator panelAnim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        panelAnim = GameObject.Find("TitlePanels").GetComponent<Animator>();
        startedAnim = false;
        //EasyButton(); //default easy
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerCar.isPlaying && !startedAnim)
        {
            anim.Play(clip);
            startedAnim = true;
        }
    }

    public void EasyButton()
    {
        Debug.Log("EASY SELECTED");
        clip = easyAI.name.ToString();
        panelAnim.Play("TitlePanels");
    }

    public void MediumButton()
    {
        Debug.Log("MEDIUM SELECTED");
        clip = mediumAI.name.ToString();
        panelAnim.Play("TitlePanels");
    }

    public void HardButton()
    {
        Debug.Log("HARD SELECTED");
        clip = hardAI.name.ToString();
        panelAnim.Play("TitlePanels");
    }

    public void ProButton()
    {
        Debug.Log("PRO SELECTED");
        clip = proAI.name.ToString();
        panelAnim.Play("TitlePanels");
    }


    //Course button will have course manager script later
    public void DesertCourseButton()
    {
        playButton.SetActive(true);
    }
}
