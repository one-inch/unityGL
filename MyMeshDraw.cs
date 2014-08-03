using UnityEngine;
using System.Collections;

public class MyMeshDraw : MonoBehaviour
{
	public Vector2[] uvs;
	public Vector3[] verts;
	public int[] trangles;
	private MeshFilter meshFilter = null;
	public Material material = null;
	public Mesh mesh = null;
	// Use this for initialization
	void Start () 
	{
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		meshFilter = GetComponent<MeshFilter>();
		this.mesh = new Mesh();
		this.meshFilter.mesh = this.mesh;
		GetComponent<MeshRenderer>().material = this.material;
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.meshFilter.mesh.vertices = verts;
		this.meshFilter.mesh.uv = uvs;
		this.meshFilter.mesh.triangles = trangles;
	}
}
