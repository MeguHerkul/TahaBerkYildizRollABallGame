using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Follow target (the ball)
    public GameObject target;

    private Vector3 cameraOffset;

    void Start()
    {
        // Calculate distance between camera and ball at the start
        cameraOffset = transform.position - target.transform.position;
    }

    // LateUpdate is better for camera follow scripts
    void LateUpdate()
    {
        // Follow the target's position with the offset
        transform.position = target.transform.position + cameraOffset;
    }
}