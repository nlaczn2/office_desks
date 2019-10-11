using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights1 : MonoBehaviour
{

    public GameObject tallLightOn;
    public GameObject tallLightOff;
    public GameObject smallLightOn;
    public GameObject smallLightOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void somefn() {
        if (!tallLightOn.activeInHierarchy)
        {
            tallLightOn.SetActive(true);
            tallLightOff.SetActive(false);
            smallLightOn.SetActive(true);
            smallLightOff.SetActive(false);
        }
        else if (tallLightOn.activeInHierarchy)
        {
            tallLightOn.SetActive(false);
            tallLightOff.SetActive(true);
            smallLightOn.SetActive(false);
            smallLightOff.SetActive(true);
        }
    }
}
