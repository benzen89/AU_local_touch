using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class stop_video : MonoBehaviour
{
    GameObject playbackSphere;

    Lean.Touch.LeanPitchYawSmooth yaw;

    void Start()
    {
        playbackSphere = GameObject.Find("VideoPlaybackSphere");
        yaw = GameObject.Find("Camera Pivot").GetComponent<Lean.Touch.LeanPitchYawSmooth>();
    }

    public void StopVideo(){
        VideoPlayer vp = playbackSphere.GetComponent<VideoPlayer>();
        vp.clip = null;
        vp.Stop();

        AudioSource ap = playbackSphere.GetComponent<AudioSource>();
        ap.clip = null;
        ap.Stop();

        // Reset yaw and limit to 180 horizontal view range
        yaw.Yaw = 0;
        yaw.YawMin = -90;
        yaw.YawMax = 90;
    }
}
