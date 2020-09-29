using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum City {Helsinki, Tallin, Cesis, Gavle, Viimsi, Daugava, Stockholm}

public class city_activator : MonoBehaviour
{
    /*
    This script is attached to any gameobject (for example UI Canvas) 
    and contains a function for changing cities.
    */

    public GameObject[] cities;

    public void ChangeCity(int cityIndex)
    {
        for(int i = 0; i < cities.Length; i++)
        {
            cities[i].SetActive(false);
        }
        cities[cityIndex].SetActive(true);
    }

}
