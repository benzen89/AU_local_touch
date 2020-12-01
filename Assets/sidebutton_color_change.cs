using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sidebutton_color_change : MonoBehaviour
{
    GameObject[] sideButtons;
    public Sprite activeImage;
    public Sprite inactiveImage;
    private void Start()
    {
        sideButtons = GameObject.FindGameObjectsWithTag("SideButton");
    }
    public void Change_btn_color()
    {
        foreach (GameObject button in sideButtons)
        {
            button.GetComponent<Image>().sprite = button.GetComponent<sidebutton_color_change>().inactiveImage;
        }
        transform.GetComponent<Image>().sprite = activeImage;
    }
}

