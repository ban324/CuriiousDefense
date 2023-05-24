using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeIShuriken : MonoBehaviour, IShuriken
{
    public bool isThisReal;
    public float speed;

    Transform playerTransform;
    float startDistance;
    Vector3 dir;
    
    public void OnHIt()
    {
        throw new System.NotImplementedException();
    }
    void Awake()
    {
        playerTransform = FindObjectOfType<Player>().GetComponent<Transform>();
        startDistance = GetDistance(transform.position.x, playerTransform.position.x);
    }
    void Start()
    {
        dir = playerTransform.position - transform.position;
        dir = dir.normalized;
        if (!isThisReal)
        {
            StartCoroutine(Fake());
        }
    }
    void Update()
    {
        transform.position += speed * Time.deltaTime * dir;
    }
    IEnumerator Fake()
    {
        print("fake");
        while(true)
        {
            if (startDistance / 2 >= GetDistance(transform.position.x, playerTransform.position.x))
            {
                Destroy(gameObject);
            }
            yield return null;
        }
    }
    float GetDistance(float me, float player)
    {
        return Mathf.Abs(me - player);
    }
}
