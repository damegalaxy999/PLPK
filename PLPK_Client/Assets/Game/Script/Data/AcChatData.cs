using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcChatData
{
    public int Index { set; get; }
    public string Owner { set; get; }
    public string Message { set; get; }

    public void UpdateData(AcChatData updateChatData)
    {
        this.Index = updateChatData.Index;
        this.Owner   = updateChatData.Owner;
        this.Message = updateChatData.Message;
    }
}
