using UnityEngine;
 
public static class RendererExtensions
{
    public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
 
    public static bool IsVisibleFrom(this Renderer renderer, Camera camera,float safeZone)
    {
        Bounds _comfortZone = new Bounds(renderer.bounds.center, renderer.bounds.size * safeZone);
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, _comfortZone);
    }
}