using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_menu_button_info_panel_changer : MonoBehaviour
{

    info_panel_change info_Panel_Change;
    current_city_infos all_Panels;

    public int button_index; //the index of the button (about = 0, resilience = 1, etc.)

    private void Start()
    {
        info_Panel_Change = GameObject.Find("Canvas").GetComponent<info_panel_change>();
        all_Panels = transform.parent.GetComponent<current_city_infos>();
    }

    public void ChangeInfo()
    {
        print("info panel : " + info_Panel_Change + " /// all_panels: " + all_Panels + " /// button index: " + button_index);
        info_Panel_Change.ChangeInfoPanel(all_Panels.current_infos[button_index]);
        
    }
}
