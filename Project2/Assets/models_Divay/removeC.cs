using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeC : MonoBehaviour
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
    public void eat(){
        if (fire.activeInHierarchy)
        {
            fire.SetActive(false);
            
        }
    }
}
