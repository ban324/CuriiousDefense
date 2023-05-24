using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryItem : MonoBehaviour,IisItem
{
    GameObject HealthManager;

    private void Start()
    {
        HealthManager = GameObject.Find("HealthManager");
    }
    public void OnTake()
    {
        
        HealthManager.GetComponent<PlayerHealth>().HealHealth(20);
        HealthManager.GetComponent<PlayerHealth>().Shealth();
    }

}
