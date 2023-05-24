using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeShurikenSpawner : MonoBehaviour
{
    List<bool> list = new List<bool>();
    [SerializeField] GameObject prefab;
    void Awake()
    {
        SetRandom();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            list.Clear();
            SetRandom();
            Spawn();
        }
    }
    void SetRandom()
    {
        bool a = false;
        for (int i = 0; i < 3; i++) // 3 spawn // 정말 정말 정말 정말 효율적이지 못한 알고리즘
        {
            if (i == 2 && a == false)
            {
                list.Add(true);
            }
            else if (Random.Range(0, 2) == 1 && a == false)
            {
                a = true;
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            print(list[i]);
        }
    }
    void Spawn()
    {
        for (int i = 0; i < 3; i++) {
            GameObject shuriken = Instantiate(prefab, transform.GetChild(i).position, Quaternion.identity);
            shuriken.GetComponent<FakeIShuriken>().isThisReal = list[i];
            print(shuriken.GetComponent<FakeIShuriken>().isThisReal);
        }
    }
}
