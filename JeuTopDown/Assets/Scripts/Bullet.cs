using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float lifeTimeBullet = 10f;
    [SerializeField] private GameObject _explosionVFX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveTheBall());
    }

    //TODO : Le faire déplacer tout droit jusqu'à qu'il rencontre un obstacle + timer ou lui mettre une distance maximum

    private void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player" && other.tag != "Ground")
        {
            Instantiate(_explosionVFX, this.transform.position, Quaternion.Euler(new Vector3(90f,0f,0f)));
            Destroy(gameObject);
            if (other.tag == "Box")
            {
                other.GetComponent<Box>().BoxTouched();
            }
        }
        
        
    }

    IEnumerator MoveTheBall()
    {
        yield return new WaitForSeconds(lifeTimeBullet);
        Destroy(gameObject);
    }
}
