using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;
    private float cameraY;

    void Start()
    {
        cameraY = transform.position.y;// Start the game with camera at 0 y coords
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Only move the camera up
        if (target.position.y > cameraY)
        {
            cameraY = target.position.y;
        }

        Vector3 targetPosition = new Vector3(transform.position.x, cameraY + offset.y, offset.z);

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}