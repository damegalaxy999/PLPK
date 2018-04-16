using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcChatManager : LcSinglton<AcChatManager>
{
    List<AcChatData> m_ChatDataList = new List<AcChatData>(SystemDefine.CHAT_MAX);

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
        LcEventManager<AcChatData>.Instance().NotificationEventList(ref chatDataList);
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
