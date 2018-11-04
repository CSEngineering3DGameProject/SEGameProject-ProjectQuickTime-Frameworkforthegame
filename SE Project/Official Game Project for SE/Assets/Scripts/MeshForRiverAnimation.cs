using UnityEngine;
using System.Collections.Generic;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
public class MeshClassForRiverMesh : MonoBehaviour
{
    public int[] Verticies;
    public int[] Polygons;
    public int[] newUVMap;
    public float MeshSizeControl = 1000f;
    public int MaximumMeshSizeHeight = 1000;
    public int MaximumMeshSizeWidth = 1000;
    private MeshFilter filter;
    public float size = 1;

    void Start()
    {
        filter = GetComponent<MeshFilter>();
        filter.mesh = GenerateMesh();

    }

    void Update()
    {

    }

    Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();
        return mesh;

    }
}




