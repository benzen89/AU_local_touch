using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_style_change : MonoBehaviour
{
    // This script is attached to any game object (for example UI Canvas) and contains a function for changing the map style
    public GameObject[] map_togglables;
    public void Change_to_about_map()
    {
        GameObject activeMap = GameObject.FindWithTag("Map");
        if (activeMap && activeMap.GetComponent<map_styles>())
        {
            Sprite map = activeMap.GetComponent<map_styles>().aboutMap;
            activeMap.GetComponent<SpriteRenderer>().sprite = map;
        }
        else
        {
            Debug.Log("map_styles component or Map tag missing");
        }
       
        for (int i = 0; i < map_togglables.Length; i++)
        {
            if (map_togglables[i].CompareTag("About"))
            {
                map_togglables[i].gameObject.SetActive(true);
            }
            else
            {
                map_togglables[i].gameObject.SetActive(false);
            }
        }

    }
    public void Change_to_resilience_map()
    {
        GameObject activeMap = GameObject.FindWithTag("Map");
        if (activeMap && activeMap.GetComponent<map_styles>())
        {
            Sprite map = activeMap.GetComponent<map_styles>().resilienceMap;
            activeMap.GetComponent<SpriteRenderer>().sprite = map;
        }
        else
        {
            Debug.Log("map_styles component or Map tag missing");
        }

        for (int i = 0; i < map_togglables.Length; i++)
        {
            if (map_togglables[i].CompareTag("Resilience"))
            {
                map_togglables[i].gameObject.SetActive(true);
            }
            else
            {
                map_togglables[i].gameObject.SetActive(false);
            }
        }
    }
    public void Change_to_participation_map()
    {
        GameObject activeMap = GameObject.FindWithTag("Map");
        if (activeMap && activeMap.GetComponent<map_styles>())
        {
            Sprite map = activeMap.GetComponent<map_styles>().participationMap;
            activeMap.GetComponent<SpriteRenderer>().sprite = map;
        }
        else
        {
            Debug.Log("map_styles component or Map tag missing");
        }

        for (int i = 0; i < map_togglables.Length; i++)
        {
            if (map_togglables[i].CompareTag("Participation"))
            {
                map_togglables[i].gameObject.SetActive(true);
            }
            else
            {
                map_togglables[i].gameObject.SetActive(false);
            }
        }
    }
    public void Change_to_technology_map()
    {
        GameObject activeMap = GameObject.FindWithTag("Map");
        if (activeMap && activeMap.GetComponent<map_styles>())
        {
            Sprite map = activeMap.GetComponent<map_styles>().technologyMap;
            activeMap.GetComponent<SpriteRenderer>().sprite = map;
        }
        else
        {
            Debug.Log("map_styles component or Map tag missing");
        }

        for (int i = 0; i < map_togglables.Length; i++)
        {
            if (map_togglables[i].CompareTag("Technology"))
            {
                map_togglables[i].gameObject.SetActive(true);
            }
            else
            {
                map_togglables[i].gameObject.SetActive(false);
            }
        }
    }

    public void Change_to_plans_map()
    {
        GameObject activeMap = GameObject.FindWithTag("Map");
        if (activeMap && activeMap.GetComponent<map_styles>())
        {
            Sprite map = activeMap.GetComponent<map_styles>().plansMap;
            activeMap.GetComponent<SpriteRenderer>().sprite = map;
        }
        else
        {
            Debug.Log("map_styles component or Map tag missing");
        }

        for (int i = 0; i < map_togglables.Length; i++)
        {
            if (map_togglables[i].CompareTag("Plans"))
            {
                map_togglables[i].gameObject.SetActive(true);
            }
            else
            {
                map_togglables[i].gameObject.SetActive(false);
            }
        }
    }

}
