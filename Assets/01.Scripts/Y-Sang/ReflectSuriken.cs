using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectSuriken : MonoBehaviour, IShuriken
{
    public void OnHIt()
    {
        throw new System.NotImplementedException();
    }

    float timer;
    int Reflect = 1;
    bool reflect = false;

    [SerializeField] float _speed;
    [SerializeField] Vector3 _dir;
    public GameObject player;
    private void Start()
    {
        player = GameManager.Instance.playerObject.gameObject;
        _dir = (player.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
    private void Update()
    {
        timer += Time.deltaTime * Reflect;
        Vector3 a = transform.rotation.eulerAngles;
        a.z += _speed * Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(a);
        _speed = GameManager.Instance.speed;

        transform.position += Vector3.Distance(player.transform.position, transform.position) * 0.1f * _dir * Time.deltaTime * _speed * Reflect;

        if(reflect == true && timer <= 0)
        {
            Reflect *= -1;
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            if(reflect == false)
            {
                Reflect *= -1;
                reflect = true;
            }
            else
            {
                Destroy(this.gameObject);
            }  
        }
    }
}