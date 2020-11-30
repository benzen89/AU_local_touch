using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
    public bool invert = false;

    Transform mainCameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        mainCameraTransform = Camera.main.transform;
        //Debug.Log(mainCameraTransform);
    }

    // Update is called once per frame
    void Update()
    {
        if(invert){
            transform.LookAt(transform.position - mainCameraTransform.position);
        } else{
            transform.LookAt(mainCameraTransform);
        }
    }
}
