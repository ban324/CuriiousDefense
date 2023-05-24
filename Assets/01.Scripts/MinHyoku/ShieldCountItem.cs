using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCountItem : MonoBehaviour,IisItem
{
    GameObject ShieldAdd;

    private void Start()
    {
        ShieldAdd = GameObject.Find("ShieldAdd");    
    }
    public void OnTake()
    {
        ShieldAdd.SetActive(true);
    }

    


}
