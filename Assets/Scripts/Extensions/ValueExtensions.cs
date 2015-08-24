using UnityEngine;

public static class ValueExtensions
{
    /// <summary>
    /// Checks if the difference between two decimals are less tthan or equal to Epsilon.
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="float2"></param>
    /// <returns></returns>
    public static bool AlmostEquals(this float float1, float float2)
    {
        return (Mathf.Abs(float1 - float2) <= float.Epsilon);
    }

    /// <summary>
    /// if the difference between two decimals are less than or equal to precision.
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="float2"></param>
    /// <param name="precision"></param>
    /// <returns></returns>
    public static bool IsSimiliar(this float float1, float float2, float precision)
    {
        return (Mathf.Abs(float1 - float2) <= precision);
    }

    /// <summary>
    /// if the difference between two decimals are less than precision.
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="float2"></param>
    /// <param name="precision"></param>
    /// <returns></returns>
    public static bool IsDifferanceLessThan(this float float1, float float2, float precision)
    {
        return (Mathf.Abs(float1 - float2) < precision);
    }

    /// <summary>
    /// if the difference between two decimals are greater than precision.
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="float2"></param>
    /// <param name="precision"></param>
    /// <returns></returns>
    public static bool IsDifferanceBiggerThan(this float float1, float float2, float precision)
    {
        return (Mathf.Abs(float1 - float2) > precision);
    }

    /// <summary>
    /// Rounds the number to the given multiple. 
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    public static float RoundToMultiple(this float float1, float multiple)
    {
        if (float1 >= 0) return Mathf.Floor((float1 + multiple / 2) / multiple) * multiple;
        return Mathf.Ceil((float1 - multiple / 2) / multiple) * multiple;
    }

    /// <summary>
    /// Rounds the number to the given multiple. 
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    public static int RoundToMultiple(this int int1, float multiple)
    {
        return (int)RoundToMultiple((float)int1, multiple);
    }

    /// <summary>
    /// Floors the number to the given multiple. 
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    public static float FloorToMultiple(this float float1, float multiple)
    {
       return Mathf.Floor((float1) / multiple) * multiple;
    }

    /// <summary>
    /// Floors the number to the given multiple. 
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    public static int FloorToMultiple(this int int1, float multiple)
    {
        return (int)FloorToMultiple((float)int1, multiple);
    }

    /// <summary>
    /// Ceils the number to the given multiple. 
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    public static float CeilToMultiple(this float float1, float multiple)
    {
        return Mathf.Ceil((float1) / multiple) * multiple;
    }

    /// <summary>
    /// Ceils the number to the given multiple. 
    /// </summary>
    /// <param name="float1"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    public static int CeilToMultiple(this int int1, float multiple)
    {
        return (int)CeilToMultiple((float)int1, multiple);
    }
}