using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocateSpeedItem : MonoBehaviour,IisItem
{

    GameObject Player;

    public void OnTake()
    {
        //플레이어의 속도를 조절하는 코드
        //
        //
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Find");
    }

}
