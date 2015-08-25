using UnityEngine;
using System.Collections;
 
public static class Vector3Extensions
{
 
    /// <summary>
    /// Rotates x angle by given angle.
    /// </summary>
    /// <param name="v">Vector3 to be rotated.</param>
    /// <param name="angle">Angle.</param>
    public static void RotateX(this Vector3 v, float angle)
    {
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);
 
        float ty = v.y;
        float tz = v.z;
 
        v.y = (cos * ty) - (sin * tz);
        v.z = (cos * tz) + (sin * ty);
    }


    /// <summary>
    /// Rotates y angle by given angle.
    /// </summary>
    /// <param name="v">Vector3 to be rotated.</param>
    /// <param name="angle">Angle.</param>
    public static void RotateY(this Vector3 v, float angle)
    {
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);
 
        float tx = v.x;
        float tz = v.z;
 
        v.x = (cos * tx) + (sin * tz);
        v.z = (cos * tz) - (sin * tx);
 
    }


    /// <summary>
    /// Rotates z angle by given angle.
    /// </summary>
    /// <param name="v">Vector3 to be rotated.</param>
    /// <param name="angle">Angle.</param>
    public static void RotateZ(this Vector3 v, float angle)
    {
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);
 
        float tx = v.x;
        float ty = v.y;
 
        v.x = (cos * tx) - (sin * ty);
        v.y = (cos * ty) + (sin * tx);
    }

    /// <summary>
    /// Returns angle between two vectors depending on the reference vector in -179, 180 range.
    /// </summary>
    /// <param name="vectorOne">Ex: 1,0,0 (Right)</param>
    /// <param name="vectorTwo">Ex: 0,0,1 (Forward)</param>
    /// <param name="normal">Ex: 0,1,0 (Up)</param>
    /// <returns></returns>
    public static float GetAngleBetween(this Vector3 vectorOne, Vector3 vectorTwo, Vector3 normal)
	{
		// angle in [0,180]
		float angle = Vector3.Angle(vectorOne, vectorTwo);
		float sign = Mathf.Sign(Vector3.Dot(normal, Vector3.Cross(vectorOne, vectorTwo)));

		// angle in [-179,180]
		float signed_angle = angle * sign;

		return signed_angle;
	}

    /// <summary>
	/// Returns angle between two vectors depending on the reference vector in 0, 360 range.
	/// </summary>
	/// <param name="vectorOne">Ex: 1,0,0 (Right)</param>
	/// <param name="vectorTwo">Ex: 0,0,1 (Forward)</param>
	/// <param name="normal">Ex: 0,1,0 (Up)</param>
	/// <returns></returns>
	public static float GetAngleBetween360(this Vector3 vectorOne, Vector3 vectorTwo, Vector3 normal)
    {
        // angle in [0,180]
        float angle = Vector3.Angle(vectorOne, vectorTwo);
        float sign = Mathf.Sign(Vector3.Dot(normal, Vector3.Cross(vectorOne, vectorTwo)));

        // angle in [-179,180]
        float signed_angle = angle * sign;

        // angle in [0,360]
        float angle360 =  (signed_angle + 180) % 360;

        return angle360;
    }
}