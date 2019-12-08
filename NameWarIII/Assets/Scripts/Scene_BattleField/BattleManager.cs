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
        //初始化玩家数据
        player1Data = player1.playerData;
        player2Data = player2.playerData;
        //初始化回合数
        turnCount = 0;
        
        //调试语句, 如果数据不完整就重新创建下数据
        if (player1Data.playerStand == null || player2Data.playerStand == null)
        {
            DebugFun();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("战斗即将开始");
        player2.SayWords(player2.playerData.enterWords);

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

    /// <summary>
    /// 回合切换及玩家行动
    /// </summary>
    void DoTrun()
    {
        //偶数回合玩家1行动,反之玩家2行动
        if ((turnCount % 2) == 0)
        {
            //临时一人说一句话
            player1.SayWords(player1.playerData.enterWords);

            //临时攻击
            StartCoroutine(Attack(player1, player2, 2.5f));
        }
        else
        {

        }
    }
}
