using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LcSinglton<T> where T : class , new()
{
    protected static T m_instance;
    public static T Instance()
    {
        if(m_instance == null)
        {
            m_instance = new T();
        }
        return m_instance;
    }

    //そこまでの負担を継承先にかけるのもよくないので無し
    /*public void _reset()
    {

    }*/
}
