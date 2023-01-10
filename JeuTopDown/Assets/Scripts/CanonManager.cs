using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonManager : MonoBehaviour
{

    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Transform _bulletAnchor;
    [SerializeField] private ParticleSystem _shootVFX;
    private AudioSource _shootSFX;
    public AudioClip _test;
    
    public float shootCooldown = 1f;

    private bool _canShoot = true;

    private void Awake()
    {
        //_shootSFX = GetComponent<AudioSource>();
    }

    public void Shoot()
    {
        if (_canShoot == true)
        {
            Instantiate(_bulletPrefab, _bulletAnchor.position, transform.rotation);
            _shootVFX.Play();
            SoundManager.InstanceSoundManger.PlaySound(_test);
            StartCoroutine(ShootCooldown());
        }
        
    }
    
    IEnumerator ShootCooldown()
    {
        _canShoot = false;
        yield return new WaitForSeconds(shootCooldown);
        _canShoot = true;
    }
}
