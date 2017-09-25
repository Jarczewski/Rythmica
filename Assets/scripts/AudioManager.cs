using Assets.scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public List<AudioClip> randomAudios;

    System.Random rnd;

    // Use this for initialization
    void Start ()
    {
        rnd = new System.Random();
	}

    public void PlayTrack(List<SoundData> track)
    {

    }
   
    public void PlayRandom()
    {
        int elo = rnd.Next(randomAudios.Count);

        AudioSource.PlayClipAtPoint(randomAudios[elo], transform.position);
    }
}
