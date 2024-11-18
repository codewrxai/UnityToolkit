#if UNITY_EDITOR
using System;
using System.IO;

using UnityEditor;
using UnityEngine;

public class AI_PairProgrammer : EditorWindow
{
    public const string YOUR_GITHUB_COPILOT = "https://github.com/settings/copilot";

    [MenuItem("Toolkit/Developer Options/Your Copilot Dashboard", false, 72)]
    static void AI_GithubCopilot()
    {
        Application.OpenURL(AI_PairProgrammer.YOUR_GITHUB_COPILOT);
    }
}
#endif