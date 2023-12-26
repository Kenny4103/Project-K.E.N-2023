using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        Vector3[] vertices = mesh.vertices;
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] += Random.insideUnitSphere * 2;
        }
        mesh.vertices = vertices;
        mesh.RecalculateNormals();
    }

}
