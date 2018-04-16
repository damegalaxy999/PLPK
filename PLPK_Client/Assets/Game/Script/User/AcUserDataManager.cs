using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataManager : LcSinglton<UserDataManager>
{
    AcUserData m_userData;  //ユーザーデータ
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdateUserData(ref AcUserData userData)
    {
        m_userData = userData;
    }
}
