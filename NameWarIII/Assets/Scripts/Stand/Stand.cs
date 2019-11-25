using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stand, 源自日本漫画家的作品<<JOJO的奇妙冒险>>中的设定, 中文被翻译为"替身", 拥有替身能力的人, 被称之为替身使者
/// 替身将会提供基本的战斗能力, 并且可以对使用者的能力数值进行一定的修正
/// </summary>
[RequireComponent(typeof(StandFloat))]
[RequireComponent(typeof(Animator))]
public class Stand : MonoBehaviour
{
    //替身名称
    public string standName;

    //替身的动作动画
    Animator anim;

    private void Awake()
    {
        //获取动画播放组件
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
    }

    /// <summary>
    /// 普通攻击方法
    /// </summary>
    /// <param name="player">施展普通攻击的玩家</param>
    /// <param name="target">普通攻击的目标玩家</param>
    public virtual void Attack(Scb_PlayerData target)
    {
        anim.SetTrigger("Attack");
        StartCoroutine(WaitAndDo(target));
    }

    IEnumerator WaitAndDo(Scb_PlayerData target)
    {
        yield return new WaitForSeconds(1f);
        target.playerStand.GetComponent<Stand>().GetDamage();
    }

    /// <summary>
    /// 收到伤害时的播放动画
    /// </summary>
    public virtual void GetDamage()
    {
        anim.SetTrigger("GetDamage");
    }
    
}
