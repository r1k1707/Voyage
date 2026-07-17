using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    public float invincibleTime = 1f;
    private SpriteRenderer spriteRenderer;
    private bool canTakeDamage = true;
    private bool isDead;
    public GameManagerUI gameManagerUI;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // takes damage when touches enemy ship
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!canTakeDamage) return;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            TakeDamage();
        }
    }
    // takes damage when enemy bullet hits
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canTakeDamage) return;

        if (collision.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        Debug.Log("W another life");
        lives--;
        for (int i = 0; i < livesUI.Length; i++)
        {
            livesUI[i].enabled = i < lives;
        }
        if (lives <= 0 && !isDead)
        {
            gameManagerUI.GameOver(); 
            isDead = true;
            Debug.Log("ggs go next");
            Destroy(gameObject);
            return;
        }
        StartCoroutine(DamageFlash());
    }

    // damage flash when hit
    IEnumerator DamageFlash()
    {
        canTakeDamage = false;

        for (int i = 0; i < 5; i++)
        {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(0.1f);

            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }

        canTakeDamage = true;
    }
}