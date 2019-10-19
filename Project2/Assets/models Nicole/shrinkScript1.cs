using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrinkScript1 : MonoBehaviour
{
    public int small = 0;
    public int normal = 0;
    public int big = 0;

    public GameObject officeLoud;
    public GameObject officeSoft;
    public GameObject officeNorm;


    public GameObject talkLoud;
    public GameObject talkSoft;
    public GameObject talkNorm;


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

        if (small == 1) {
            officeLoud.SetActive(true);
            talkLoud.SetActive(true);
            officeSoft.SetActive(false);
            talkSoft.SetActive(false);
            officeNorm.SetActive(false);
            talkNorm.SetActive(false);
        }
        else if (normal == 1) {
            officeLoud.SetActive(false);
            talkLoud.SetActive(false);
            officeSoft.SetActive(false);
            talkSoft.SetActive(false);
            officeNorm.SetActive(true);
            talkNorm.SetActive(true);
        }
        else if (big == 1) {
            officeLoud.SetActive(false);
            talkLoud.SetActive(false);
            officeSoft.SetActive(true);
            talkSoft.SetActive(true);
            officeNorm.SetActive(false);
            talkNorm.SetActive(false);
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
