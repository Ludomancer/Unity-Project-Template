using UnityEngine;
using System.Collections.Generic;

public static class GameObjectExtensions
{
    public static string GetHierarchyString(this GameObject go)
    {
        string hierarchy = go.name;
        Transform currentTransform = go.transform;
        while (currentTransform.parent)
        {
            hierarchy += "." + currentTransform.parent.name;
            currentTransform = currentTransform.parent;
        }
        return hierarchy;
    }

    public static T[] GetComponentsInChildrenNoRoot<T>(this GameObject obj) where T : Component
    {
        List<T> tList = new List<T>();
        foreach (Transform child in obj.transform)
        {
            T[] scripts = child.GetComponentsInChildren<T>();
            if (scripts != null)
            {
                foreach (T sc in scripts)
                    tList.Add(sc);
            }
        }
        return tList.ToArray();
    }
}