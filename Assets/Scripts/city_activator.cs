using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum City {Helsinki, Tallin, Cesis, Gavle, Viimsi, Daugava, Stockholm}

public class city_activator : MonoBehaviour
{
    /*
    This script is attached to any gameobject (for example UI Canvas) 
    and contains a function for changing cities.
    */

    //This enables and disables city parent objects
    public GameObject[] cities;
    public void ChangeCity(int cityIndex)
    {
        for(int i = 0; i < cities.Length; i++)
        {
            cities[i].SetActive(false);
        }
        cities[cityIndex].SetActive(true);
    }

    //This changes the planning process image
    public void Change_Planning_Process(Sprite mySprite)
    {
        GameObject planningProcessImage;
        planningProcessImage = GameObject.Find("PlanningProcessImage");
        planningProcessImage.GetComponent<Image>().sprite = mySprite;
    }

    //This changes and enables the minimap
    public void Change_Mini_Map(Sprite myMiniMap){
        GameObject minimap;
        minimap = GameObject.Find("MiniMap");
        Image mmImg;
        mmImg = minimap.GetComponent<Image>();
        mmImg.enabled = true;
        mmImg.sprite = myMiniMap;
    }

}
