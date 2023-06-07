using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp;
    public int maxHp;
    public bool isDead = false;
    bool fastAlready = false;
    [SerializeField] float _speed;

    private void OnCollisionEnter(Collision collision)
    {
        hp--;
        Destroy(collision.gameObject);      // obj pool
        Slidermanager.instance.OnDamage(hp);
        if (hp <= 0)
        {
            isDead = true;
            GameManager.Instance.GameOver();
        }
        print("아얏");
    }
    void Update()
    {
        if (isDead) return;
        Vector3 a = transform.rotation.eulerAngles;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            a.y -= Time.deltaTime * _speed;
            transform.rotation = Quaternion.Euler(a);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            a.y += Time.deltaTime * _speed;
            transform.rotation = Quaternion.Euler(a);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            a.y += 180;
            transform.rotation = Quaternion.Euler(a);
        }
        
    }

    IEnumerator SpeedIncrease(int delay) // 눈에 띄게 효과 넣기
    {
        _speed = GameManager.Instance.speed * 180 + 200;
        fastAlready = true;
        yield return new WaitForSeconds(delay);
        fastAlready = false;
    }

    private void FixedUpdate()
    {
        if (!fastAlready)
        {
            _speed = GameManager.Instance.speed * 180;
        }
        //_speed = Mathf.Clamp(_speed, 0, 720f);
    }
}
