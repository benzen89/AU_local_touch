using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class stop_video : MonoBehaviour
{
    GameObject playbackSphere;

    void Start()
    {
        playbackSphere = GameObject.Find("VideoPlaybackSphere");
    }

    public void StopVideo(){
        VideoPlayer vp = playbackSphere.GetComponent<VideoPlayer>();
        vp.clip = null;
        vp.Stop();

        AudioSource ap = playbackSphere.GetComponent<AudioSource>();
        ap.clip = null;
        ap.Stop();
    }
}
