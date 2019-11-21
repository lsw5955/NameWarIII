using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hero
{
    //最大生命值
    public int ShengMing { get; set; }
    //攻击力
    public int GongJi { get; set; }
    //精准度
    public int MingZhong { get; set; }
    //闪避值
    public int ShanBi { get; set; }
    //姓名
    public string XingMing { get; set; }
    //职业
    internal string ZhiYe { get; set; }

    public virtual void BornWords()
    {
        Debug.Log("["+ XingMing + "]擦了擦身上的泥土, 发现自己已经变成了一名["+ ZhiYe + "]");
    }

    public virtual void Skill1()
    {

    }
}
