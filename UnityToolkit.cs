using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///////////////////////////////////////////////
// TODO: Add platform specific runtime tools //
///////////////////////////////////////////////

namespace TOOLKIT
{
    public class SceneManager
    {
        public static void LogMessage(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        public static void LogWarning(string message)
        {
            UnityEngine.Debug.LogWarning(message);
        }

        public static void LogError(string message)
        {
            UnityEngine.Debug.LogError(message);
        }
    }

    public class ScriptComponent : MonoBehaviour
    {
        public float GetDeltaTime()
        {
            return Time.deltaTime;
        }
    }
}
