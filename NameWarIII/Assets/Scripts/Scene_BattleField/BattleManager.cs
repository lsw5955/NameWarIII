using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 处理战斗逻辑
/// </summary>
public class BattleManager : MonoBehaviour
{
    //需要俩玩家参与战斗过程
    public Scb_PlayerData player1;
    public Scb_PlayerData player2;

    /// <summary>
    /// 调试方法
    /// </summary>
    void DebugFun()
    {        
        //为玩家数据赋值, 数据使用姓名作为随机种子
        player1.CreatPlayer("雄凤山", PlayerNo.Player1);
        player2.CreatPlayer("乌仁吉", PlayerNo.Player2);
    }

    // Start is called before the first frame update
    void Start()
    {
        if(player1.mingZi == "" || player2.mingZi == "")
        {
            DebugFun();
        }
        Debug.Log("战斗即将开始");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
