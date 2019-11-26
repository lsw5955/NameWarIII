using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 处理战斗逻辑
/// </summary>
public class BattleManager : MonoBehaviour
{
    //回合数字
    int turnCount;

    

    //两个玩家
    public Player player1;
    public Player player2;


    //需要俩玩家参与战斗过程
    Scb_PlayerData player1Data;
    Scb_PlayerData player2Data;

    /// <summary>
    /// 调试方法
    /// </summary>
    void DebugFun()
    {
        //为玩家数据赋值, 数据使用姓名作为随机种子
        player1Data.CreatPlayer("雄凤山", PlayerNo.Player1);
        player2Data.CreatPlayer("乌仁吉", PlayerNo.Player2);
    }

    private void Awake()
    {
        player1Data = player1.playerData;
        player2Data = player2.playerData;

        Debug.Log(player1Data.playerStand + "||" + player2Data.playerStand);
        if (player1Data.playerStand == null || player2Data.playerStand == null)
        {
            DebugFun();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("战斗即将开始");
        //
        player1.SayWords(player1.playerData.enterWords);
        player2.SayWords(player2.playerData.enterWords);
        StartCoroutine(Attack(player1,player2,2.5f));
        StartCoroutine(Attack(player2,player1,5f));
    }

    IEnumerator Attack(Player Executor,Player target,float lag)
    {
        yield return new WaitForSeconds(lag);
        Executor.Attack(target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
