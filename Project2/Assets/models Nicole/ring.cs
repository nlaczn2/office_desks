﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
    public AudioClip music;
    public AudioSource Source;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Source.isPlaying == false)
        {
            Source.PlayOneShot(music);
        }
    }
}
