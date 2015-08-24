using UnityEngine;
 
public static class RendererExtensions
{
    /// <summary>
    /// Is the renderer bounds visible from given Camera.
    /// </summary>
    /// <param name="renderer"></param>
    /// <param name="camera"></param>
    /// <returns></returns>
    public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }

    /// <summary>
    /// Is the renderer bounds multiplied by given safeZone is visible from given Camera.
    /// </summary>
    /// <param name="renderer"></param>
    /// <param name="camera"></param>
    /// <returns></returns>
    public static bool IsVisibleFrom(this Renderer renderer, Camera camera,float safeZone)
    {
        Bounds _comfortZone = new Bounds(renderer.bounds.center, renderer.bounds.size * safeZone);
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, _comfortZone);
    }
}