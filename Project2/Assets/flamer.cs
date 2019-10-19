using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flamer : MonoBehaviour
{

    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void somefnk() 
    {
        if (!fire.activeInHierarchy)
        {
            fire.SetActive(true);
            
        }
        else if (fire.activeInHierarchy)
        {
            fire.SetActive(false);
        }
    }
}
