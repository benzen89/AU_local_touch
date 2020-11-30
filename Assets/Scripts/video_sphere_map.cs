using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class video_sphere_map : MonoBehaviour
{
    /*
    This script is attached to the spheres floating above the map. 
    The sphere starts myClip video on the VideoPlaybackSphere object.
    */

    public VideoClip myClip;

    public AudioClip myAudio;

    GameObject playbackSphere;

    Lean.Touch.LeanPitchYawSmooth yaw;

    void Start()
    {
        playbackSphere = GameObject.Find("VideoPlaybackSphere");
        yaw = GameObject.Find("Camera Pivot").GetComponent<Lean.Touch.LeanPitchYawSmooth>();
    }

    void OnMouseDown(){
        // Play 360 video
        VideoPlayer vp = playbackSphere.GetComponent<VideoPlayer>();
        vp.clip = myClip;
        vp.Play();

        AudioSource ap = playbackSphere.GetComponent<AudioSource>();
        ap.clip = myAudio;
        ap.Play();

        // Allow 360 horizontal rotation
        yaw.YawMin = -180;
        yaw.YawMax = 180;

        //disable minimap
        GameObject minimap;
        minimap = GameObject.Find("MiniMap");
        minimap.GetComponent<Image>().enabled = false;

    }
}
