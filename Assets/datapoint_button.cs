using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datapoint_button : MonoBehaviour
{
    info_panel_change info_Panel_Change;
    public GameObject newInfo;
    Image infoDisplay;
    public Sprite newSprite;

    private void Start()
    {
        info_Panel_Change = GameObject.Find("Canvas").GetComponent<info_panel_change>();
        infoDisplay = GameObject.Find("info_image_display").GetComponent<Image>();
    }
    public void OnMouseDown()
    {
        info_Panel_Change.ChangeInfoPanel(newInfo);
        if (newSprite != null) //set newSprite as the new image on viewer, if a sprite has been specified
        {
            infoDisplay.sprite = newSprite;
        }
        else //disable the image component if a sprite hasn't been specified
        {
            infoDisplay.enabled = false;
        }
        
        if (infoDisplay.enabled == false && newSprite != null) //enable the image component if off and if a sprite has been specified
        {
            infoDisplay.enabled = true;
        }
    }
}
