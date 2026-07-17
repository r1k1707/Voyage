using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed;
    private PointManager pointManager;
    public GameObject bulletsPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y <= -6)
        {
            Destroy(bulletsPrefab);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pointManager.UpDateScore(0);
        }
    }
}
