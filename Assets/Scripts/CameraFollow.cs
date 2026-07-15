using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Target Settings
    public Transform target; // Drag player here
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    // Movement settings
    public float smoothTime = 0.3f; // Time taken for camera to catch up

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = new Vector3(transform.position.x, target.position.y + offset.y, target.position.z + offset.z);

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
