using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco_Time : MonoBehaviour
{
    public GameObject DiscoBallON;
    public GameObject DISCOOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpinDisco() {

        if (!DiscoBallON.activeInHierarchy)
        {
            DiscoBallON.SetActive(true);
            DISCOOff.SetActive(false);

        }
        else if (DiscoBallON.activeInHierarchy)
        {
            DiscoBallON.SetActive(false);
            DISCOOff.SetActive(true);
        }
    }
}
