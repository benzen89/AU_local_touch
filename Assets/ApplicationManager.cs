using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{

    public static bool mainPanelIsHidden;
    public static bool infoScreenIsOpen;
    public static bool highlightModeOn;
    public static bool sceneIsChanging;

  

    public GameObject actionButtons;
    

    public GameObject controlBlock;

    void Start()
    {
        ApplicationManager.mainPanelIsHidden = true;
    }


    //INFO SCREEN
    public void turnOn_infoScreen()
    {
        infoScreenIsOpen = true;
    }

    public void turnOff_infoScreen()
    {
        infoScreenIsOpen = false;
    }



    //HIGHLIGHT MODE
    public void turnOn_highlightMode()
    {
        highlightModeOn = true;
    }

    public void turnOff_highlightMode()
    {
        highlightModeOn = false;
    }




    //Main panel ...Markku

    public void turnOn_MyMainPanel()
    {
        ApplicationManager.mainPanelIsHidden = false;
    }


    public void turnOff_MyMainPanel()
    {
        ApplicationManager.mainPanelIsHidden = true;
        CancelInvoke("reveal_MainPanel");
    }


}
