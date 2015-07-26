using UnityEngine;
using System.Collections;
 
public static class Vector3Extensions
{
 
    public static void RotateX(this Vector3 v, float angle)
    {
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);
 
        float ty = v.y;
        float tz = v.z;
 
        v.y = (cos * ty) - (sin * tz);
        v.z = (cos * tz) + (sin * ty);
    }
 
 
 
    public static void RotateY(this Vector3 v, float angle)
    {
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);
 
        float tx = v.x;
        float tz = v.z;
 
        v.x = (cos * tx) + (sin * tz);
        v.z = (cos * tz) - (sin * tx);
 
    }
 
 
 
    public static void RotateZ(this Vector3 v, float angle)
    {
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);
 
        float tx = v.x;
        float ty = v.y;
 
        v.x = (cos * tx) - (sin * ty);
        v.y = (cos * ty) + (sin * tx);
    }
}