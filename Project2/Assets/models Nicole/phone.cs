using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone : MonoBehaviour
{
    public GameObject Soundss;
    public AudioClip music;
    public AudioSource Source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void phonePlag() {
        if (!Soundss.activeInHierarchy)
        {
            Soundss.SetActive(true);
            Source.Play();


        }
        else if (Soundss.activeInHierarchy)
        {
            Soundss.SetActive(false);
            Source.Stop();
        }
    }
}
