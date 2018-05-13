﻿using System.IO;

public class SpriteTitleChange : UnityEditor.AssetModificationProcessor
{
    private static void OnWillCreateAsset(string path)
    {
        path = path.Replace(".meta", "");
        if (path.EndsWith(".cs"))
        {
            string allText = File.ReadAllText(path);
            allText = allText.Replace("#AuthorName#", "Sheen")
                              .Replace("#CreateTime#", System.DateTime.Now.Year + "/" + System.DateTime.Now.Month
                + "/" + System.DateTime.Now.Day + " " + System.DateTime.Now.Hour + ":"
                + System.DateTime.Now.Minute + ":" + System.DateTime.Now.Second);

            File.WriteAllText(path, allText);
        }

    }
}