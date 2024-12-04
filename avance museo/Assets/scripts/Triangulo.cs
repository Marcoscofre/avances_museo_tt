using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TriangleMesh : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        // Define los vértices del triángulo
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(0, 0, 0),  // Primer vértice
            new Vector3(1, 0, 0),  // Segundo vértice
            new Vector3(0, 1, 0)   // Tercer vértice
        };

        // Define los triángulos (en sentido de las agujas del reloj)
        int[] triangles = new int[]
        {
            0, 1, 2  // Define la cara usando los vértices
        };

        // Asigna los vértices y triángulos al mesh
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // Opcional: calcula normales y aplica el bounding box
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
    }
}
