using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datapoint_button : MonoBehaviour
{
    info_panel_change info_Panel_Change;
    public GameObject newInfo;

    private void Start()
    {
        info_Panel_Change = GameObject.Find("Canvas").GetComponent<info_panel_change>();
    }
    private void OnMouseDown()
    {
        info_Panel_Change.ChangeInfoPanel(newInfo);
    }
}
