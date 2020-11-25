using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class application_start : MonoBehaviour
{
    public Button firstCityButton;
    GameObject[] cities;
    public GameObject firstCity;

    void Start()
    {
        Invoke("StartCity", 0.2f);
    }
    public void StartCity()
    {
        cities = GameObject.FindGameObjectsWithTag("City");
        foreach (GameObject city in cities)
        {
            if (city != firstCity)
            {
                city.SetActive(false);
            }
        }
        firstCityButton.onClick.Invoke();
    }
}
