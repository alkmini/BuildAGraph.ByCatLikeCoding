using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class meshGenerator : MonoBehaviour
{
    Mesh mesh;
    
    Vector3[] vertices;
    int[] triangles = new int[3];

    public int xSize = 20;
    public int zSize = 20;

    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
        
    }

    void CreateShape()
    {

        vertices = new Vector3[(xSize + 1) * (zSize + 1)];

        
        for ( int i = 0, z = 0 ; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                vertices[1] = new Vector3(x, 0, z);
                i++;
            }

        }

        triangles = new int[3];
        triangles[0] = 0;
        triangles[1] = xSize + 1;
        triangles[2] = 1;

        //vertices = new Vector3[]
        //{
        //    new Vector3 (0,0,0),
        //    new Vector3 (0,0,1),
        //    new Vector3 (1,0,0),
        //    new Vector3 (1, 0, 1)
        //};

        //triangles = new int[]
        //{
        //    0, 1, 2, 1, 3, 2
        //};

        
    }

    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

    private void OnDrawGizmos()
    {
        if (vertices == null)
            return;
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], .1f);
        }
    }
}
