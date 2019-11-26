﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerNo
{
    Player1,
    Player2
}

[CreateAssetMenu(fileName = "new PlayerData", menuName = "创建玩家数据")]
//[SerializeField]
public class Scb_PlayerData : ScriptableObject
{

    //姓名
    public string mingZi;
    //职业
    public string zhiYe;
    //最大生命值
    public int shengMing;
    //攻击力
    public int gongJi;
    //精准度
    public int mingZhong;
    //闪避值
    public int shanBi;

    //当前生命值
    public int currentShengMing;

    //登场台词
    public string enterWords;

    //玩家序号...可能有用, 没用删掉
    public PlayerNo playerNo;
    //玩家替身使者
    public Stand playerStand;

    //根据名称 生成属性, 同样字符串生成的属性不变
    public void CreatPlayer(string playerName, PlayerNo playerNo)
    {
        //Debug.Log("生成玩家数据");
        zhiYe = "战士";
        mingZi = playerName;
        shengMing = 100;
        gongJi = 20;
        mingZhong = 70;
        shanBi = 20;
        currentShengMing = shengMing;
        this.playerNo = playerNo;
        if(playerNo == PlayerNo.Player2)
        {
            playerStand = Instantiate((GameObject)Resources.Load("Prefabs/Stands/StandWarrior")).GetComponent<Stand>();
        }
        else
        {
            playerStand = Instantiate((GameObject)Resources.Load("Prefabs/Stands/StandWolfman")).GetComponent<Stand>();
        }
        //防止对象实例在跳转场景时被销毁 后续应该会改成跳转过去再初始化数据
        DontDestroyOnLoad(playerStand);
        enterWords = playerStand.enterWords;
        //Debug.Log(playerStand);
    }
}
