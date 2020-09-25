using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_style_change : MonoBehaviour
{
    // This script is attached to any game object (for example UI Canvas) and contains a function for changing the map style

    public void Change_to_default_map(){
        GameObject activeMap = GameObject.FindWithTag("Map");
        Debug.Log(activeMap);
        if(activeMap){
            Sprite map = activeMap.GetComponent<map_styles>().defaultMap;
            Debug.Log(map);
            activeMap.GetComponent<SpriteRenderer>().sprite = map;
        }
    }

    public void Change_to_alternative_map(){
        GameObject activeMap = GameObject.FindWithTag("Map");
        Debug.Log(activeMap);
        if(activeMap){
            Sprite map = activeMap.GetComponent<map_styles>().alternativeMap;
            Debug.Log(map);
            activeMap.GetComponent<SpriteRenderer>().sprite = map;
        }
    }
    
}
