using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public float moveSpeed;
    public GameObject bullets;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullets, transform.position, Quaternion.identity);
        }
    }
}
