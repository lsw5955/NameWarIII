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
    //替身登场台词
    public string enterWords;

    //因为每个图片都尺寸不一, 需要设置一个坐标偏移 微调下
    public Vector3 posOffSet;

    //攻击到对方的特效
    public ParticleSystem attackEffect;

    //替身的动作动画
    Animator anim;

    public virtual void Awake()
    {
        //获取动画播放组件
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        standName = "始祖";
        enterWords = "一切因我而起, 就由我来终结";
    }

    /// <summary>
    /// 普通攻击方法
    /// </summary>
    /// <param name="player">施展普通攻击的玩家</param>
    /// <param name="target">普通攻击的目标玩家</param>
    public virtual void Attack(Player target)
    {
        Debug.Log(anim);
        anim.SetTrigger("Attack");
        StartCoroutine(WaitAndDo(target));
    }

    IEnumerator WaitAndDo(Player target)
    {
        yield return new WaitForSeconds(1f);
        target.playerData.playerStand.GetComponent<Stand>().GetDamage();
    }

    /// <summary>
    /// 收到伤害时的播放动画
    /// </summary>
    public virtual void GetDamage()
    {
        anim.SetTrigger("GetDamage");
        
        Destroy(Instantiate(attackEffect, transform.position,Quaternion.identity), 1f);
        
    }
    
}
