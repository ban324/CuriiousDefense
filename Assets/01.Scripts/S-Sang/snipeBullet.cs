using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snipeBullet : MonoBehaviour
{
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
    private void FixedUpdate()
    {
        Vector3 a = transform.rotation.eulerAngles;
        a.z += _speed * Time.deltaTime * 500;
        transform.rotation = Quaternion.Euler(a);
        _speed = GameManager.Instance.speed * 2;

        transform.position += Vector3.Distance(player.transform.position, transform.position) * _dir * Time.deltaTime * _speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
