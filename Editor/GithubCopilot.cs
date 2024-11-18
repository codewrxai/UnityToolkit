#if UNITY_EDITOR
using System;
using System.IO;

using UnityEditor;
using UnityEngine;

public class AI_PairProgrammer : EditorWindow
{
    public const string YOUR_COPILOT_DASHBOARD = "https://github.com/settings/copilot";
    public const string YOUR_COPILOT_EXTENSION = "https://marketplace.visualstudio.com/items?itemName=MackeyKinard.codewrx-unity-agent";

    [MenuItem("Toolkit/Developer Options/Your Copilot Dashboard", false, 72)]
    static void AI_GithubCopilot()
    {
        Application.OpenURL(AI_PairProgrammer.YOUR_COPILOT_DASHBOARD);
    }
    [MenuItem("Toolkit/Developer Options/Install Copilot Chat Agent", false, 73)]
    static void AI_CopilotAgent()
    {
        Application.OpenURL(AI_PairProgrammer.YOUR_COPILOT_EXTENSION);
    }
}
#endif