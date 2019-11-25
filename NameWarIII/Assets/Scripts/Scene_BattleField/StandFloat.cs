using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 让替身表现出浮动感觉
/// </summary>
public class StandFloat : MonoBehaviour
{
    //浮动时间
    public float floatTime = 1;
    //浮动距离
    public float floatDistance = 0.3f;    
    //记录浮动运动的起始点
    Vector2 originPos;
    //浮动运动计时器
    float timeCount;
    //浮动运动的距离

    // Start is called before the first frame update
    void Start()
    {
        //设置浮动起始点为当前坐标
        originPos = transform.position;
        //初始化计时器
        timeCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MoveDestination();
        timeCount += Time.deltaTime;

        //如果计时器达到上限, 重置计时器并且重新设定浮动起点和浮动距离
        if (timeCount >= floatTime)
        {
            //isUp = !isUp;
            timeCount = 0;
            originPos = transform.position;
            floatDistance = -floatDistance;
        }
    }

    /// <summary>
    /// 浮动方法
    /// </summary>
    void MoveDestination()
    {
        transform.position = Vector2.Lerp(originPos, originPos + new Vector2(0,floatDistance), timeCount / floatTime);
    }
}
