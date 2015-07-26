using UnityEngine;

internal static class MeshExtensions {
    
    public static void SetVertexColor(this Mesh mesh, Color c)
    {
        Color[] colors = new Color[mesh.vertexCount];
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = c;
        }
        mesh.colors = colors;
    }
}