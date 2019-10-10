using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{

    public AudioClip musicClip;
    public AudioSource musicSource;

    public void musics(){

        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
        else if (musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
