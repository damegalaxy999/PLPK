using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEvent<T> where T : class, new()
{
    void notificationEvent(ref T updateData);
    T getTemplateType();
}
