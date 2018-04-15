using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LogLevel
{
    LL_DEBUG = 0,
    LL_WARNING,
    LL_ERROR,
}

public class AcLogger 
{   
    public static void Debug(string log)
    {
        UnityEngine.Debug.Log(log);
    }

    public static void Warning(string log)
    {
        UnityEngine.Debug.LogWarning(log);
    }


    public static void Error(string log)
    {
        UnityEngine.Debug.LogError(log);
    }

}

