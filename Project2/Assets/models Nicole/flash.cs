using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class flash : MonoBehaviour
{
    public GameObject tallLightOn;


    // Start is called before the first frame update
    public void StartPrint()
    {
        if (!tallLightOn.activeInHierarchy)
        {
            tallLightOn.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
            //other stuff

    }

}
