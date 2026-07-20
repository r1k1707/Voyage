using UnityEngine;

public class LevelClear : MonoBehaviour
{
    public GameObject levelClear;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelClear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            levelClear.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("about time bro");
        }
    }
}
