using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singlton<T> where T : class , new()
{
    protected static Singlton<T> m_instance;
    public static Singlton<T> Instance()
    {
        if(m_instance == null)
        {
            m_instance = new Singlton<T>();
            if(!m_instance._init())
            {
                AcLogger.Log("Singlton Init Warning", LogLevel.LL_WARNING);
            }
        }
        return m_instance;
    }

    public bool _init()
    {        
        return true;
    }

    //そこまでの負担を継承先にかけるのもよくないので無し
    /*public void _reset()
    {

    }*/
}
