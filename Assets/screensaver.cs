using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screensaver : MonoBehaviour
{
    public float timer;
    public GameObject _AUPanel;
    public float secondsToScreenSaver = 50f;
    void Start()
    {
        timer = Time.time + secondsToScreenSaver;
    }

    void Update()
    {
        if (Input.anyKey)
        {
            timer = Time.time + secondsToScreenSaver;
        }
        if (Time.time > timer)
        {
            _AUPanel.SetActive(true);
        }
    }
}
