using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFast : MonoBehaviour, IisItem
{
    public void OnTake()
    {
        Time.timeScale = 2f;
    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
