using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcChatManager : Singlton<AcChatManager>
{
    List<AcChatData> m_ChatDataList = new List<AcChatData>(SystemDefine.CHAT_MAX);

    public new bool _init()
    {
        if(!base._init())
        {
            return false;            
        }
        m_ChatDataList.Clear();
        return true;
    }
    
    public List<AcChatData> GetChatLogList()
    {
        return m_ChatDataList;
    }

    public AcChatData GetChatData(int index)
    {
        AcChatData findData = m_ChatDataList.Find(x => x.Index == index);
        if(findData != null)
        {
            return findData;
        }
        return null;
    }

    public void SetAcChatDataList(List<AcChatData> chatDataList)
    {
        m_ChatDataList = chatDataList;
    }

    public void AddAcChatDataList(List<AcChatData> chatDataList)
    {
        m_ChatDataList.ForEach(a =>
        {
            chatDataList.ForEach(b =>
            {
                if(a.Index == b.Index)
                {
                    a = b;
                }
                else
                {
                    m_ChatDataList.Add(b);
                }
            });
        });
    }
    
}
