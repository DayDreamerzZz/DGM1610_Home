using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public int socialClass = 1;

    void Start()
    {
        switch(npcConv)
        { 
            case "Hello":
            Debug.Log("Hello good citizen! May the blessing of Zandar be upon you!");
            break;
            case "Goodbye":
            Debug.Log("Farewell!");
            break;
            case "We are being attacked":
            Debug.Log("you run away in shame, you coward!");
            break;
        
        }

        /*
        switch(socialClass0)
        {
            case 5:
                Debug.Log("Hello you're Magesty!");
                break;
            case 4:
                Debug.Log("Hello Young Princess!");
                break:
            case 3:
                Debug.Log("Good evening Duke Urtho!");
                break;
            case 2:
                Debug.Log("Hello, Mayor!");
                break;
            case 1:
                Debug.Log("May I purchase some of your fine cheeses?");
                break;
            case 0:
                Debug.Log("Get away from me you riff raff!");
            default:
                Debug.Log("I do not talk with strangers!!!");
                break;
          } */        
         }
    }