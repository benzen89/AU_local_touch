﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class match_rotation : MonoBehaviour
{
    
    public GameObject modelObj;

    void LateUpdate()
    {
        transform.rotation = modelObj.transform.rotation;
    }
}
