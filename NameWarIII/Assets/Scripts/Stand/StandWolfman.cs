using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 第二个替身 原型是啥呢 没想好 反正就是挺狠
/// </summary>
public class StandWolfman : Stand
{
    public override void Awake()
    {
        base.Awake();
        standName = "狂野尖啸";
        enterWords = "如果用自己的血,可以交换到敌人的血,那就值得.";
    }

    private void Update()
    {
        
    }
}
