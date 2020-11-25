using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class force_about_on_city_change : MonoBehaviour
{
    public GameObject about_button;
    public Button button;
    void Start()
    {
        button = about_button.GetComponent<Button>();
    }

    public void SetToAbout()
    {
        button.onClick.Invoke();
    }
    void Update()
    {
        
    }
}
