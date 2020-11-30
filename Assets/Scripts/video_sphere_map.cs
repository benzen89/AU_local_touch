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

    void Start()
    {
        playbackSphere = GameObject.Find("VideoPlaybackSphere");
    }

    void OnMouseDown(){
        // Play 360 video
        VideoPlayer vp = playbackSphere.GetComponent<VideoPlayer>();
        vp.clip = myClip;
        vp.Play();

        AudioSource ap = playbackSphere.GetComponent<AudioSource>();
        ap.clip = myAudio;
        ap.Play();

        //disable minimap
        GameObject minimap;
        minimap = GameObject.Find("MiniMap");
        minimap.GetComponent<Image>().enabled = false;

    }
}
