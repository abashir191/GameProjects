using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public AudioSource AudioSource;

    private float soundVolume = 1f;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        AudioSource.volume =  soundVolume;
    }

    public void UpdateVol(float vol)
    {
        soundVolume = vol;
    }
}
