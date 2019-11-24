﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class RacePositionManager : MonoBehaviour
{
    public Transform[] checkpoints;

    public Image[] imagePosition;
    public Text[] textPosition;

    //Get all the cars
    GameObject[] activeAI;
    GameObject[] activePlayers;
    [HideInInspector]public List<GameObject> activeCars;


    void Start()
    {
        activeAI = GameObject.FindGameObjectsWithTag("CarAI");
        activePlayers =  GameObject.FindGameObjectsWithTag("Player");
        activeCars = activePlayers.Concat(activeAI).ToList();
    }

    void Update()
    {
        List<Tuple<GameObject, float>> currentPlaces = GetPosition(activeCars);
        DisplayPositions(currentPlaces);

        //display the position text for each place
    }

    List<Tuple<GameObject, float>> GetPosition(List<GameObject> cars)
    {
        //List<float> positionScores = new List<float>();
        List<Tuple<GameObject, float>> carPositions = new List<Tuple<GameObject, float>>();

        foreach (GameObject car in cars)
        {
            //positionScores.Add(car.GetComponent<RacingPositionSystem>().positionScore);
            carPositions.Add(Tuple.Create(car, car.GetComponent<RacingPositionSystem>().positionScore));
        }

        //Sort position
        //carPositions.OrderBy(thing => thing.Item2).ToList(); //
        carPositions.Sort((x, y) => x.Item2.CompareTo(y.Item2));

        //list = list.OrderBy(i => i.Item1).ToList();
        //list.Sort((x, y) => y.Item1.CompareTo(x.Item1));
        //positionScores.Sort();

        int it = carPositions.Capacity / 2;
        foreach (Tuple<GameObject, float> place in carPositions)
        {
            //Debug.Log("Place " + it + ": " + place.Item1.name + " " + place.Item2);
            it--;
        }

        return carPositions;
    }

    void DisplayPositions(List<Tuple<GameObject, float>> currentPlaces)
    {
        int it = currentPlaces.Capacity / 2;
        int i = 0;
        foreach (Tuple<GameObject, float> place in currentPlaces)
        {
            //Debug.Log("Place " + it + ": " + place.Item1.name + " " + place.Item2);
            imagePosition[i].color = SetColor(place);

            if(i == 0)
            {
                textPosition[i].color = new Color32(255, 234, 0, 255);
            }
            else
            {
                textPosition[i].color = new Color32(255, 255, 255, 255);
            }

            /*
            switch (i)
            {
                case 0:
                    //imagePosition[i].text = "1st: " + place.Item1.name;
                    imagePosition[i].color = SetColor(place);
                    break;
                case 1:
                    //textPosition[i].text = "2nd: " + place.Item1.name;
                    textPosition[i].color = new Color32(156, 157, 159, 255); //silver
                    break;
                case 2:
                    textPosition[i].text = "3rd: " + place.Item1.name;
                    break;
                case 3:
                    textPosition[i].text = "4th: " + place.Item1.name;
                    break;
                case 4:
                    textPosition[i].text = "5th: " + place.Item1.name;
                    textPosition[i].color = new Color32(251, 163, 26, 255); //orange ish
                    break;
                case 5:
                    textPosition[i].text = "6th: " + place.Item1.name;
                    textPosition[i].color = new Color32(233, 64, 38, 255); //red ish
                    break;
                default:
                    Debug.Log("Error for text position i:" + i + " it:" + it);
                    break;
            }*/
            it--;
            i++;
        }
    }

    Color32 SetColor(Tuple<GameObject, float> place)
    {
        string colorCar = place.Item1.name;

        if (colorCar.Contains("Red"))
        {
            return new Color32(149, 16, 16, 255);
        }
        if (colorCar.Contains("Green"))
        {
            return new Color32(5, 144, 5, 255);
        }
        if (colorCar.Contains("Blue"))
        {
            return new Color32(19, 19, 171, 255);
        }
        if (colorCar.Contains("Orange"))
        {
            return new Color32(255, 152, 0, 255);
        }
        if (colorCar.Contains("Purple"))
        {
            return new Color32(120, 32, 111, 255);
        }
        if (colorCar.Contains("Yellow"))
        {
            return new Color32(255, 198, 0, 255);
        }
        return Color.white;


    }
}