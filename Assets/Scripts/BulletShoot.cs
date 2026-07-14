using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject bulletsPrefab;
    public float time = 1.0f;
    public float timer = 0;

    void Start()
    {

    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                shootBullet();
                timer = 0;
            }
        }
    }

    void shootBullet()
    {
            Instantiate(bulletsPrefab, transform.position, Quaternion.identity);
            Debug.Log("yeah fight back");
    }
}
