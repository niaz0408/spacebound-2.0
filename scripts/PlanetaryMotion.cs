
using UnityEngine;

public class PlanetaryMotion : MonoBehaviour
{
    public Transform sun;

    public float orbitSpeed = 20f;
    public float rotationSpeed = 30f;

    void Update()
    {
        // Revolution around the Sun
        if (sun != null)
        {
            transform.RotateAround(
                sun.position,
                Vector3.up,
                orbitSpeed * Time.deltaTime
            );
        }

        // Rotation around the planet's own axis
        transform.Rotate(
            Vector3.up,
            rotationSpeed * Time.deltaTime,
            Space.Self
        );
    }
}
