using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    private float hInput;
    private float vInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);

        vInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector2.up * vInput * moveSpeed * Time.deltaTime);
    }
}
