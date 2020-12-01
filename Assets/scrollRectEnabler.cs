using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollRectEnabler : MonoBehaviour
{

    public ScrollRect scrollRect;
    // Start is called before the first frame update
    void Start()
    {
        scrollRect = GameObject.Find("Scroll View").GetComponent<ScrollRect>();
        scrollRect.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
