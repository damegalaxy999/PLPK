using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcUserData
{
    public int UserId { get { return m_UserId; } }
    public string UserName { get { return m_UserName; } }

    int m_UserId;
    string m_UserName;

    AcUserData()
    {
        m_UserId = 0;
        m_UserName = "";
    }

    public void SetData(int userId, string userName )
    {
        m_UserId = userId;
        m_UserName = userName;
    }
}
