using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // for the enemy speed
    public float speed;
    public GameObject enemyPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        // finding the enemy prefabs current position
        Vector2 position = transform.position;

        // Calculating the new position of enemies
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        // line to update the enemy position
        transform.position = position;

        // this refers to the bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        // if enemy leaves screen from bottom of screen, then destroy object
        if (transform.position.y <= -6)
        {
            Destroy(enemyPrefab);
        }

    }
}
