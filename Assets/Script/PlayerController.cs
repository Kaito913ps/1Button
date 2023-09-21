using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField,Tooltip("�e�e�̃v���n�u")]
    private GameObject _bulletPrefab;
    [SerializeField,Tooltip("�e�e�̔��ˈʒu")]
    private Transform _firePoint;
    [SerializeField,Tooltip("�e�e�̑��x")]
    private float _bulletSpeed = 10f;

    void Update()
    {
        //�{�^���������ꂽ��e�e�𔭎�
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //�e�e�𐶐����A���ˈʒu�ɔz�u
        GameObject bullet = Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);

        //�e�e�ɑ��x��ݒ�
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * _bulletSpeed;
    }
}
