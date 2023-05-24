using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubShield : MonoBehaviour
{
    public int cnt;
    public int origin_cnt;
    public void Init()
    {
        cnt = origin_cnt;
    }
    private void OnCollisionEnter(Collision collision)
    {
        cnt--;
        Destroy(collision.gameObject);
        if (cnt <= 0) gameObject.SetActive(false);
    }
}
