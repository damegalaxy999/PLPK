using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEvent<T> where T : class, new()
{
    void NotificationEventList(ref List<T> updateData);
}
