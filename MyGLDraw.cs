using UnityEngine;
using System.Collections;

public class MyGLDraw : MonoBehaviour 
{
	public Material material = null;

	void OnPostRender()
	{
		GL.PushMatrix();
		material.SetPass(0);
		GL.LoadOrtho();
		GL.Begin(GL.QUADS);
		GL.TexCoord2(0, 0);
		GL.Vertex3(0, 0, 0);
		GL.TexCoord2(0, 1);
		GL.Vertex3(0, 1, 0);
		GL.TexCoord2(1, 1);
		GL.Vertex3(1, 1, 0);
		GL.TexCoord2(1, 0);
		GL.Vertex3(1, 0, 0);
		GL.End();
		GL.PopMatrix();
	}
}
