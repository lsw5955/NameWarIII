using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 屌逼的第一个替身, 他的原型将是无敌的承太郎欧不白金之星
/// </summary>
public class StandWarrior : Stand
{
    public override void Awake()
    {
        base.Awake();
        standName = "白金之星";
        enterWords = "你失败的原因只有一个, 那就是你惹怒我了!";
    }

    private void Update()
    {
        
    }
}
