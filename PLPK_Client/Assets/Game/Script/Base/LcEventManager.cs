using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LcEventManager<T> : LcSinglton<LcEventManager<T>> where T : class, new()
{    
    public List<IEvent<T>> m_eventListenerList = new List<IEvent<T>>();

    // 消し忘れると惨事なので使用する際には細心の注意を払うこと...
    // もう少し安全にしたいが良い方法ない？
    public void RegisterEventInterFace(IEvent<T> iEvent)
    {
        if (iEvent == null) return;

        m_eventListenerList.Add(iEvent);
    }

    public void UnregisterEventInterFace(IEvent<T> iEvent)
    {
        if (iEvent == null) return;

        m_eventListenerList.Remove(iEvent);
    }

    public void NotificationEventList(ref List<T> eventData)
    {
        foreach(var listener in m_eventListenerList)
        {
            listener.NotificationEventList(ref eventData);
        }
    }
}
