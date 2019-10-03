using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienFeedSystem : MonoBehaviour
{
    //public Text alienFoodText;
    public AlienCravingSystem alienCravingSystem;

    private string foodAlienWouldEat;
    private string foodHardName;
    private int howManyAlienWants;
    private int howManyAlienHas;
    //private bool FinishedFeeding;

    private void Start()
    {
        //FinishedFeeding = false;
    }

    private void Update()
    {

        int caseSwitch = AlienCravingSystem.rnum;

        switch (caseSwitch)
        {
            case 0: //Cactus
                Debug.Log("Level 1 case 0");
                foodAlienWouldEat = "C";
                foodHardName = "C";
                howManyAlienWants = 1;
                break;
            case 1: //Purple Cactus
                Debug.Log("Level 2 case 1");
                foodAlienWouldEat = "CactusPurple";
                foodHardName = "C";
                howManyAlienWants = 1;
                break;
            case 2: //Green Cactus 
                Debug.Log("Level 2 case 2");
                foodAlienWouldEat = "CactusGreen";
                foodHardName = "C";
                howManyAlienWants = 1;
                break;
            case 3: //Blue Cactus
                Debug.Log("Level 2 case 3");
                foodAlienWouldEat = "CactusBlue";
                foodHardName = "C";
                howManyAlienWants = 1;
                break;
            case 4: //Yellow Cactus
                Debug.Log("Level 2 case 4");
                foodAlienWouldEat = "CactusYellow";
                foodHardName = "C";
                howManyAlienWants = 1;
                break;
            case 5: //Red Cactus
                Debug.Log("Level 2 case 5");
                foodAlienWouldEat = "CactusRed";
                foodHardName = "C";
                howManyAlienWants = 1;
                break;
            case 6: //Cactus with Flower
                Debug.Log("level 3");
                foodAlienWouldEat = "C";
                foodHardName = "Flower";
                howManyAlienWants = 1;
                break;
            case 7: // Red Cactus with Flower
                Debug.Log("level 4 case 1 of 5");
                foodAlienWouldEat = "CactusRed";
                foodHardName = "Flower";
                howManyAlienWants = 1;
                break;
            case 8: // Blue Cactus with Flower
                Debug.Log("level 4 case 2 of 5");
                foodAlienWouldEat = "CactusBlue";
                foodHardName = "Flower";
                howManyAlienWants = 1;
                break;
            case 9: // Green Cactus with Flower
                Debug.Log("level 4 case 3 of 5");
                foodAlienWouldEat = "CactusGreen";
                foodHardName = "Flower";
                howManyAlienWants = 1;
                break;
            case 10: // Yellow Cactus with Flower
                Debug.Log("level 4 case 4 of 5");
                foodAlienWouldEat = "CactusYellow";
                foodHardName = "Flower";
                howManyAlienWants = 1;
                break;
            case 11: // Purple Cactus with Flower
                Debug.Log("level 4 case 5 of 5");
                foodAlienWouldEat = "CactusPurple";
                foodHardName = "Flower";
                howManyAlienWants = 1;
                break;

                //LEVEL 5: Color of Cactus and Color of Flower

            case 12: // Yellow Cactus with Red Flower
                Debug.Log("level 5 case 1 of 5");
                foodAlienWouldEat = "CactusYellow";
                foodHardName = "RedFlower";
                howManyAlienWants = 1;
                break;
            case 13: // Green Cactus with Yellow Flower
                Debug.Log("level 5 case 2 of 5");
                foodAlienWouldEat = "CactusGreen";
                foodHardName = "YellowFlower";
                howManyAlienWants = 1;
                break;
            case 14: // Blue Cactus with Red Flower
                Debug.Log("level 5 case 3 of 5");
                foodAlienWouldEat = "CactusBlue";
                foodHardName = "RedFlower";
                howManyAlienWants = 1;
                break;
            case 15: // Red Cactus with Blue Flower
                Debug.Log("level 5 case 4 of 5");
                foodAlienWouldEat = "CactusRed";
                foodHardName = "BlueFlower";
                howManyAlienWants = 1;
                break;
            case 16: // Purple Cactus with Yellow Flower
                Debug.Log("level 5 case 5 of 5");
                foodAlienWouldEat = "CactusPurple";
                foodHardName = "YellowFlower";
                howManyAlienWants = 1;
                break;

                //Level 6  - case 17 - Cactus with Cowboy hat

                //Level 7 - case 18 - 22 - Color Cactus with Cowboy hat 

                //Level 8 (Any case)

            default:
                Debug.Log("error! no case");
                foodAlienWouldEat = "Error";
                foodHardName = "Error";
                howManyAlienWants = 1;
                break;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        //if alien wants the food
        if (collision.gameObject.tag.Contains(foodAlienWouldEat) &&
            collision.gameObject.name.Contains(foodHardName))
        {
            Debug.Log("fed alien...");
            Destroy(collision.gameObject);
            howManyAlienHas++;
            //if you get all the food the alien wants
            if (howManyAlienHas >= howManyAlienWants)
            {
                //play alien fed sound
                Debug.Log("alien all fed");
                alienCravingSystem.cravingMet = true;
                howManyAlienWants = 0;
            }
        }
        //if alien doesn't want the food
        if (!collision.gameObject.tag.Contains(foodAlienWouldEat) &&
            !collision.gameObject.name.Contains(foodHardName) && collision.gameObject.tag != "Car")
        {
            Debug.Log("Alien: I don't want that!");
        }
    }
}
