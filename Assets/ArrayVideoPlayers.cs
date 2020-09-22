using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ArrayVideoPlayers : MonoBehaviour
{

    public GameObject[] videoPlayers;

    void StopVideoPlaying()
    {
        videoPlayers[1].SetActive(false);
        videoPlayers[2].SetActive(false);
        videoPlayers[3].SetActive(false);
        videoPlayers[4].SetActive(false);
        videoPlayers[5].SetActive(false);
        videoPlayers[6].SetActive(false);
        videoPlayers[7].SetActive(false);
        videoPlayers[8].SetActive(false);
        videoPlayers[9].SetActive(false);
        videoPlayers[10].SetActive(false);
        videoPlayers[11].SetActive(false);
        videoPlayers[12].SetActive(false);
        videoPlayers[13].SetActive(false);
        videoPlayers[14].SetActive(false);
        videoPlayers[15].SetActive(false);
        videoPlayers[16].SetActive(false);



    }

    void StarttttVideoPlaying()
    {
        videoPlayers[1].SetActive(true);
        videoPlayers[2].SetActive(true);
        videoPlayers[3].SetActive(true);
        videoPlayers[4].SetActive(true);
        videoPlayers[5].SetActive(true);
        videoPlayers[6].SetActive(true);
        videoPlayers[7].SetActive(true);
        videoPlayers[8].SetActive(true);
        videoPlayers[9].SetActive(true);
        videoPlayers[10].SetActive(true);
        videoPlayers[11].SetActive(true);
        videoPlayers[12].SetActive(true);
        videoPlayers[13].SetActive(true);
        videoPlayers[14].SetActive(true);
        videoPlayers[15].SetActive(true);
        videoPlayers[16].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
}