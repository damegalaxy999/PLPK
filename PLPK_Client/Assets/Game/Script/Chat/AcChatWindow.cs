using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcChatWindow : MonoBehaviour ,IEvent<AcChatData>
{
    [SerializeField] InputField m_InputField;   // 入力
    [SerializeField] Button m_SendButton;       // 送信ボタン
    [SerializeField] Text m_TextField;          // 表示部

    List<AcChatData> m_ChatDataList;            // チャットデータ
    bool m_ChatDarty = true;


    //AcChatDataの変更通知
    public void NotificationEvent(ref AcChatData updateData)
    {


    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // 送信ボタンの押下
    void OnSendButton()
    {
        string input = GetInputString();

        AcChatData chatData = new AcChatData();
        chatData.Message = this.GetInputString();
        //chatData.Owner = AcUserDataManager.Instance.
        //AcNetWorkManager.Instance.SendChat(ref chatData);
    }

    string GetInputString()
    {
        return m_InputField.text;
    }
}
