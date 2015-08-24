
using UnityEngine;
 
public static class ColliderExtensions {

    /// <summary>
    /// Is the collider bounds visible from given Camera.
    /// </summary>
    /// <param name="renderer"></param>
    /// <param name="camera"></param>
    /// <returns></returns>
    public static bool IsVisibleFrom(this Collider collider, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, collider.bounds);
    }

    /// <summary>
    /// Is the collider bounds multiplied by given safeZone is visible from given Camera.
    /// </summary>
    /// <param name="renderer"></param>
    /// <param name="camera"></param>
    /// <returns></returns>
    public static bool IsVisibleFrom(this Collider collider, Camera camera, float safeZone)
    {
        Bounds _comfortZone = new Bounds(collider.bounds.center, collider.bounds.size * safeZone);
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, _comfortZone);
    }
}