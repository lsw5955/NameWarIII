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

    private void Awake()
    {
        if (player1.playerStand == null || player2.mingZi == null)
        {
            DebugFun();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("战斗即将开始");
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(2.5f);
        player1.playerStand.Attack(player2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
