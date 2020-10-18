using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class language_change : MonoBehaviour
{
    public int activeLanguage;

    public void ChangeLanguage(int language)
    {
        activeLanguage = language;

        // call UpdateLanguage() in the active info box
        GameObject.Find("Content").transform.GetChild(0).gameObject.SendMessage("UpdateLanguage");
    }
}
