﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LcSinglton<T> where T : class , new()
{
    protected static LcSinglton<T> m_instance;
    public static LcSinglton<T> Instance()
    {
        if(m_instance == null)
        {
            m_instance = new LcSinglton<T>();
            if(!m_instance._init())
            {
                AcLogger.Error("Singlton Init Warning");
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
