using UnityEngine;

public class BoundaryFollow : MonoBehaviour
{
    public Camera mainCamera;
    public float offset = -5f; // Distance below the camera

    void LateUpdate()
    {
        if (mainCamera == null) return;

        transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y + offset, transform.position.z);
    }
}