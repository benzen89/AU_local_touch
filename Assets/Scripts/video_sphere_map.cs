﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video_sphere_map : MonoBehaviour
{
    /*
    This script is attached to the spheres floating above the map. The sphere starts myClip video on the VideoPlaybackSphere object.
    */

    public VideoClip myClip;

    GameObject playbackSphere;

    void Start()
    {
        playbackSphere = GameObject.Find("VideoPlaybackSphere");
    }

    void OnMouseDown(){
        VideoPlayer vp = playbackSphere.GetComponent<VideoPlayer>();
        vp.clip = myClip;
        vp.Play();
    }
}
