using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new PlayerData", menuName = "创建玩家数据")]
//[SerializeField]
public class Scb_PlayerData : ScriptableObject
{

    //姓名
    public string mingZi;
    //职业
    internal string zhiYe;
    //最大生命值
    public int shengMing;
    //攻击力
    public int gongJi;
    //精准度
    public int mingZhong;
    //闪避值
    public int shanBi;

    //根据名称 生成属性, 同样字符串生成的属性不变
    public void CreatPlayerPower(string playerName)
    {
        zhiYe = "战士";
        mingZi = playerName;
        shengMing = 100;
        gongJi = 20;
        mingZhong = 70;
        shanBi = 20;
    }
}
