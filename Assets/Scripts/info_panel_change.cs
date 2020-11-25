using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_panel_change : MonoBehaviour
{

    /*
    This script is attached to any gameobject (for example UI Canvas) 
    and contains a function for changing the info panel.
    */

    public void ChangeInfoPanel(GameObject newInfo){
        GameObject contentPanel = GameObject.Find("Content");

        // remove old info
        Destroy(contentPanel.transform.GetChild(0).gameObject);

        // add new info
        GameObject addedInfo = Instantiate(newInfo);
        addedInfo.transform.parent = contentPanel.transform;
        
        // set new info position and scale
        RectTransform infoTransform = addedInfo.GetComponent<RectTransform>();
        infoTransform.anchoredPosition = new Vector2(0,0);
        infoTransform.localScale = new Vector3(1,1,1);

        // reset the scroll view
        contentPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,0);
        print("Pissakakakk");
        //remove duplicates
        if (contentPanel.transform.childCount > 1)
        {
            Destroy(contentPanel.transform.GetChild(0).gameObject);
        }
    }

}
