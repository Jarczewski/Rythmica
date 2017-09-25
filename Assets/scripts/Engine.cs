using Assets.scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {

    List<SoundData> currentTrack;

    public void onRythmButtonClick(RythmButton btn)
    {
        SoundData snddt=new SoundData();

        snddt.duration = btn.duration;

        snddt.isSound = btn.isSound;

        currentTrack.Add(snddt);
    }

    public void PlayTrack()
    {

    }

    void Start()
    {
        currentTrack = new List<SoundData>();
    }
}
