using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city_activator : MonoBehaviour
{
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
