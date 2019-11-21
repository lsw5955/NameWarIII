using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    //两个玩家的名称
    public InputField nameInputField1;
    public InputField nameInputField2;
    //两个玩家数据的序列化类
    public Scb_PlayerData Player1;
    public Scb_PlayerData Player2;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Battle()
    {
        //为玩家数据赋值, 数据使用姓名作为随机种子
        Player1.CreatPlayerPower(nameInputField1.text);
        Player2.CreatPlayerPower(nameInputField2.text);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(nameInputField1.text);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(nameInputField2.text);
        }
    }
}
