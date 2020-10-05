using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planning_process_change : MonoBehaviour
{

    public void Change_Planning_Process(Sprite mySprite)
    {
        GameObject planningProcessImage;
        planningProcessImage = GameObject.Find("PlanningProcessImage");
        planningProcessImage.GetComponent<Image>().sprite = mySprite;
    }
}
