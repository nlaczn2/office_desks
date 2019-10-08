using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSong : MonoBehaviour
{

    public AudioClip musicClip;
    public AudioSource musicSource;

    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "leftC" || collision.gameObject.tag == "rightC")
            {
            if (!musicSource.isPlaying)
            {
                musicSource.Play();
            }

            if (musicSource.isPlaying)
            {
                musicSource.Stop();
            }

        }
    }

    private void Update()
    {
    }
}
