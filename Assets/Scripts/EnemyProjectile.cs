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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pointManager.UpDateScore(0);
        }
        if (collision.CompareTag("Despawn"))
        {
            Destroy(bulletsPrefab);
        }
    }
}
