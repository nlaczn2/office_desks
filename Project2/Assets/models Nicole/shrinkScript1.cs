using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrinkScript1 : MonoBehaviour
{

    public GameObject Person;
    public float x = 0.3f;
    public float y = 0.3f;
    public float z = 0.3f;
    public float x1 = 0.3f;
    public float y1 = 0.3f;
    public float z1 = 0.3f;

    public void shrink() {

        Person.transform.localScale = new Vector3(x, y, z);
        Person.transform.localPosition= new Vector3(x1, y1, z1);

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
