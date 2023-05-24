using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSizeItem : MonoBehaviour,IisItem
{
    GameObject Shield;

    private void Start()
    {
        Shield = GameObject.Find("Shield");    
    }
    public void OnTake()
    {
        Shield.transform.localScale = new Vector3(2f, 2f, 2f);
    }

    


}
