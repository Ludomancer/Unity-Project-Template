using UnityEngine;

internal static class MeshExtensions {
    
    /// <summary>
    /// Sets the color value of the Mesh to given color value.
    /// </summary>
    /// <param name="mesh"></param>
    /// <param name="c"></param>
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