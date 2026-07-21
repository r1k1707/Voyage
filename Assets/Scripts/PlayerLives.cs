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

    public GameOverManager gameOverManager;
    private PointManager pointManager;
    private TimerController timer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        //find the PointManager in the scene
        pointManager = FindFirstObjectByType<PointManager>();
        //find timer in scene
        timer = FindFirstObjectByType<TimerController>();
    }

    // Takes damage when touching an enemy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!canTakeDamage) return;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            TakeDamage();
        }
    }

    // Takes damage when hit hit bullet
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
            isDead = true;

            // Save the final score n high score 
            if (pointManager != null)
            {
                pointManager.HighScoreUpdate();
            }

            if (timer != null)
            {
                timer.ShowFinalTime(); 
            }
            // Show the game over screen
            gameOverManager.GameOver();
            Debug.Log("ggs go next");
            Destroy(gameObject);
            return;
        }

        StartCoroutine(DamageFlash());
    }
    public void TimerDeath()
    {
        if (isDead) return;

        isDead = true;

        // Save score
        if (pointManager != null)
        {
            pointManager.HighScoreUpdate();
        }

        // Show final time
        if (timer != null)
        {
            timer.ShowFinalTime();
        }

        // Show game over screen
        gameOverManager.GameOver();

        Debug.Log("Time ran out");

        Destroy(gameObject);
    }

    //damage flash when hit
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