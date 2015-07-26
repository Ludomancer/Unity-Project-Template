
using UnityEngine;
 
public static class ColliderExtensions {
 
    public static bool IsVisibleFrom(this Collider collider, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, collider.bounds);
    }
 
    public static bool IsVisibleFrom(this Collider collider, Camera camera, float safeZone)
    {
        Bounds _comfortZone = new Bounds(collider.bounds.center, collider.bounds.size * safeZone);
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, _comfortZone);
    }
}