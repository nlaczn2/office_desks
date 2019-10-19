using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOPen : MonoBehaviour
{
    public GameObject tallLightOn;
    public GameObject tallLightOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void somefn()
    {
        if (tallLightOn.activeInHierarchy)
        {
            tallLightOn.SetActive(false);
            tallLightOff.SetActive(true);
        }
    }
}
