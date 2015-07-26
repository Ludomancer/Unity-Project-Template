using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.IO;

internal class CreateDefaultFolders
{
    [MenuItem("Custom/Create Default Folders")]
    private static void CreateFolders()
    {
        CreateDirectory("Animations");
        CreateDirectory("Editor");
        CreateDirectory("Materials");
        CreateDirectory("Models");
        CreateDirectory("Prefabs");
        CreateDirectory("Resources");
        CreateDirectory("Scenes");
        CreateDirectory("Scripts");
        CreateDirectory("Scripts/Managers");
        CreateDirectory("Shaders");
        CreateDirectory("Audio");
        CreateDirectory("Textures");
        CreateDirectory("Scenes");
        CreateDirectory("Fonts");
        AssetDatabase.Refresh();
    }

    private static void CreateDirectory(string name)
    {
        string path = Path.Combine(Application.dataPath, name);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
}