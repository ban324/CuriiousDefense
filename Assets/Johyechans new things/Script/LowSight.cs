using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowSight : MonoBehaviour, IisItem
{
    public void OnTake()
    {
        GameObject.Find("SightManager").GetComponent<SightManager>().LowSightArea.SetActive(true);
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
