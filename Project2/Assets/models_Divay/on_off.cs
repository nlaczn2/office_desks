using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off : MonoBehaviour
{
    public GameObject yellow_light;

    public void toggleLight()
    {
        if(yellow_light.activeInHierarchy)
        {
            yellow_light.SetActive(false);
        }
        else if(!yellow_light.activeInHierarchy)
        {
            yellow_light.SetActive(true);
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
