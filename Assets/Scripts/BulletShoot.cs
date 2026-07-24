using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject bulletsPrefab;
    public float time = 1.0f;
    public float fireRate = 0.75f;   // Time between shots
    public float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer >= fireRate)
        {
            shootBullet();
            timer = 0f;
        }
    }

    void shootBullet()
    {
        Instantiate(bulletsPrefab, transform.position, Quaternion.identity);
        Debug.Log("yeah fight back");
    }
}