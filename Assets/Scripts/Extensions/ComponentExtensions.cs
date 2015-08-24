using UnityEngine;
using System.Collections.Generic;
using System.Text;

public static class ComponentExtensions
{
    /// <summary>
    /// Returns a string that has the name of every parent the object has seperated by "." starting from the top the current object until the topmost parent.
    /// </summary>
    /// <param name="obj">Unity Component</param>
    /// <returns></returns>
    public static string GetHierarchyStringBottomUp(this Component obj)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(obj.name);
        Transform currentTransform = obj.transform;
        while (currentTransform.parent)
        {
            currentTransform = currentTransform.parent;
            sb.Append("." + currentTransform.name);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Returns a string that has the name of every parent the object has seperated by "." starting from the top parent until this object.
    /// </summary>
    /// <param name="obj">Unity Component</param>
    /// <returns></returns>
    public static string GetHierarchyStringTopDown(this Component obj)
    {
        Stack<string> names = new Stack<string>();
        names.Push(obj.name);

        Transform currentTransform = obj.transform;
        while (currentTransform.parent)
        {
            currentTransform = currentTransform.parent;
            names.Push(currentTransform.name);
        }

        StringBuilder sb = new StringBuilder();
        while (names.Count > 1)
        {
            sb.Append(names.Pop() + ".");
        }
        sb.Append(names.Pop());
        return sb.ToString();
    }

    /// <summary>
    /// Same as GetComponentsInChildren call in Unity API, but it excludes the obejct itself unlike Unity API.
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="obj">Unity Component</param>
    /// <returns></returns>
    public static T[] GetComponentsInChildrenNoRoot<T>(this Component obj) where T : Component
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