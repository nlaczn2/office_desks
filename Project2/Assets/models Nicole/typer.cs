using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typer : MonoBehaviour
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

    public void typeing() {
        if (!tallLightOn.activeInHierarchy)
        {
            tallLightOn.SetActive(true);
        }
    }
}
