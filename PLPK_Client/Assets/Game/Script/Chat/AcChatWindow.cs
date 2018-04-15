using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcChatWindow : MonoBehaviour
{
    [SerializeField] InputField m_InputField;   // 入力
    [SerializeField] Button m_SendButton;       // 送信ボタン
    [SerializeField] Text m_TextField;          // 表示部


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // 送信ボタンの押下
    void onSendButton()
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
