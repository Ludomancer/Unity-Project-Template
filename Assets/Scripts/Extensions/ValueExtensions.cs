using UnityEngine;

public static class ValueExtensions
{
    public static bool AlmostEquals(this float float1, float float2)
    {
        return (Mathf.Abs(float1 - float2) <= float.Epsilon);
    }

    public static bool IsSimiliar(this float float1, float float2, float precision)
    {
        return (Mathf.Abs(float1 - float2) <= precision);
    }

    public static bool IsDifferanceLessThan(this float float1, float float2, float precision)
    {
        return (Mathf.Abs(float1 - float2) < precision);
    }
	
	public static bool IsDifferanceBiggerThan(this float float1, float float2, float precision)
    {
        return (Mathf.Abs(float1 - float2) > precision);
    }

    public static float RoundToMultiple(this float float1, float multiple)
    {
        if (float1 >= 0) return Mathf.Floor((float1 + multiple / 2) / multiple) * multiple;
        return Mathf.Ceil((float1 - multiple / 2) / multiple) * multiple;
    }

    public static int RoundToMultiple(this int int1, float multiple)
    {
        return (int)RoundToMultiple((float)int1, multiple);
    }

    public static float FloorToMultiple(this float float1, float multiple)
    {
       return Mathf.Floor((float1) / multiple) * multiple;
    }

    public static int FloorToMultiple(this int int1, float multiple)
    {
        return (int)FloorToMultiple((float)int1, multiple);
    }

    public static float CeilToMultiple(this float float1, float multiple)
    {
        return Mathf.Ceil((float1) / multiple) * multiple;
    }

    public static int CeilToMultiple(this int int1, float multiple)
    {
        return (int)CeilToMultiple((float)int1, multiple);
    }
}