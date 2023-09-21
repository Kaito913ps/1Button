using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField,Tooltip("e’e‚ÌƒvƒŒƒnƒu")]
    private GameObject _bulletPrefab;
    [SerializeField,Tooltip("e’e‚Ì”­ËˆÊ’u")]
    private Transform _firePoint;
    [SerializeField,Tooltip("e’e‚Ì‘¬“x")]
    private float _bulletSpeed = 10f;

    void Update()
    {
        //ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚çe’e‚ğ”­Ë
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //e’e‚ğ¶¬‚µA”­ËˆÊ’u‚É”z’u
        GameObject bullet = Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);

        //e’e‚É‘¬“x‚ğİ’è
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * _bulletSpeed;
    }
}
