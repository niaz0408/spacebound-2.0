

using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public float orbitSpeed = 2f;
    public float rotationSpeed = 5f;

    private Vector3 orbitPosition;

    void Start()
    {
        orbitPosition = transform.localPosition;
    }

    void Update()
    {
        float angle = orbitSpeed * Time.deltaTime;

        orbitPosition = Quaternion.Euler(0f, angle, 0f) * orbitPosition;

        transform.localPosition = orbitPosition;

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
