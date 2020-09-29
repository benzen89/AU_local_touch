﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_panel_activator : MonoBehaviour
{
    
    public void OpenPanel(GameObject panel){
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel){
        panel.SetActive(false);
    }

}
