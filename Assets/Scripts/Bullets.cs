using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float moveSpeed;
    private PointManager pointManager;
    public GameObject bulletsPrefab;
    public float lifetime = 3.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifetime);
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up  * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            pointManager.UpDateScore(25);
            Destroy(gameObject);
        }
    }
}
