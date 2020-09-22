using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class mainPanelMovement : MonoBehaviour
{
    public Transform revealed;
    public Transform hidden;

    public float speed = 10.0f;

    void Update()
    {
        if (ApplicationManager.mainPanelIsHidden)
        {
            transform.position = Vector3.Lerp(transform.position, hidden.position, speed * Time.deltaTime);
        }

        if (!ApplicationManager.mainPanelIsHidden)
        {
            transform.position = Vector3.Lerp(transform.position, revealed.position, speed * Time.deltaTime);
        }
    }
}
