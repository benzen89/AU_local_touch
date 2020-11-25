using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class citybutton_color_change : MonoBehaviour
{
    GameObject[] cityButtons;
    public Sprite activeImage;
    public Sprite inactiveImage;
    private void Start()
    {
        cityButtons = GameObject.FindGameObjectsWithTag("CityButton");
    }
    public void Change_color()
    {      
        foreach (GameObject button in cityButtons)
        {
            button.GetComponent<Image>().sprite = button.GetComponent<citybutton_color_change>().inactiveImage;
        }
        transform.GetComponent<Image>().sprite = activeImage;
    }
}
