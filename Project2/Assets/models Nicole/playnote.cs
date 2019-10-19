using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playnote : MonoBehaviour
{
    public GameObject tallLightOn;
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
        }
        else if (!tallLightOn.activeInHierarchy)
        {
            tallLightOn.SetActive(true);
        }
    }
}
