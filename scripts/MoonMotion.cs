
using UnityEngine;

public class MoonMotion : MonoBehaviour
{
    public Transform earth;

    public float orbitSpeed = 60f;
    public float rotationSpeed = 20f;

    void Update()
    {
        if (earth != null)
        {
            // Moon revolves around Earth
            transform.RotateAround(
                earth.position,
                Vector3.up,
                orbitSpeed * Time.deltaTime
            );
        }

        // Moon rotates around its own axis
        transform.Rotate(
            Vector3.up,
            rotationSpeed * Time.deltaTime,
            Space.Self
        );
    }
}
