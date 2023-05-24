using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubShieldItem : MonoBehaviour, IisItem
{
    public GameObject subShield;
    
    public void OnTake()
    {
        subShield.SetActive(true);
    }
}
