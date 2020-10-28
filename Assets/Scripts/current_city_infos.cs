using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class current_city_infos : MonoBehaviour
{
    public GameObject[] current_infos;

    public void ChangeLeftPanelInfos(city_left_button_info_panels city_infos)
    {
        current_infos = city_infos.infos;
    }
}
