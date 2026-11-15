
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SaturnRings : MonoBehaviour
{
    public float innerRadius = 1.2f;
    public float outerRadius = 2.5f;
    public int segments = 128;

    void Start()
    {
        GenerateRing();
    }

    void GenerateRing()
    {
        Mesh mesh = new Mesh();
        mesh.name = "Saturn Ring Mesh";

        Vector3[] vertices = new Vector3[(segments + 1) * 2];
        int[] triangles = new int[segments * 6];

        for (int i = 0; i <= segments; i++)
        {
            float angle = 2f * Mathf.PI * i / segments;

            float x = Mathf.Cos(angle);
            float z = Mathf.Sin(angle);

            vertices[i * 2] =
                new Vector3(x * innerRadius, 0, z * innerRadius);

            vertices[i * 2 + 1] =
                new Vector3(x * outerRadius, 0, z * outerRadius);

            if (i < segments)
            {
                int v = i * 2;
                int t = i * 6;

                triangles[t] = v;
                triangles[t + 1] = v + 2;
                triangles[t + 2] = v + 1;

                triangles[t + 3] = v + 1;
                triangles[t + 4] = v + 2;
                triangles[t + 5] = v + 3;
            }
        }

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
