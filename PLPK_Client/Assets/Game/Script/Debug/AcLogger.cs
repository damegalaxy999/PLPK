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
    public static void Log(string log, LogLevel level)
    {
        //LogLevelでなんか変える
        Debug.Log(log);
    }
}
