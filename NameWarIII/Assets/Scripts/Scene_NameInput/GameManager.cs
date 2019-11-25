using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    //两个玩家的名称
    public InputField nameInputField1;
    public InputField nameInputField2;
    //两个玩家数据的序列化类
    public Scb_PlayerData player1;
    public Scb_PlayerData player2;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Battle()
    {
        //为玩家数据赋值, 数据使用姓名作为随机种子
        player1.CreatPlayer(nameInputField1.text,PlayerNo.Player1);
        player2.CreatPlayer(nameInputField2.text, PlayerNo.Player2);
        SceneManager.LoadScene("BattleField");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
