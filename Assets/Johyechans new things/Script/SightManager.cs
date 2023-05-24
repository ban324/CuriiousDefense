using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightManager : MonoBehaviour
{
    public GameObject LowSightArea;
    public GameObject lowSight;

    private float currenttime = 0;
    private float waittime = 3f;

    private float x = 22;
    private float z = 22;

    private float biger = 10f;
    void Start()
    {
        LowSightArea.SetActive(false);
        lowSight.transform.localScale = new Vector3(x, 0, z);
    }

    void Update()
    {
        if(GameObject.Find("Player").GetComponent<PlayerM>().lowsight)
        {
            currenttime += Time.deltaTime;
            if(x >= 10 && z >= 10)
            {
                x -= Time.deltaTime * biger;
                z -= Time.deltaTime * biger;
            }
        }
        if(currenttime >= waittime)
        {
            GameObject.Find("Player").GetComponent<PlayerM>().lowsight = false;
            currenttime = 0;
            LowSightArea.SetActive(false);
            x = 22f;
            z = 22f;
        }
        lowSight.transform.localScale = new Vector3(x, 0, z);
    }
}
