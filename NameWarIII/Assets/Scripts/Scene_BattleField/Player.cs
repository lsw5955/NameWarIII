using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 玩家各种数据与显示的初始化
/// </summary>
public class Player : MonoBehaviour
{
    //角色数据
    public Scb_PlayerData playerData;
    //角色头顶UI位置标记物体
    public Transform playerUIPos;
    //角色替身显示位置
    public Transform playerStandPos;
    //角色台词显示位置
    public Transform playerWordsPos;

    [Header("UI elements")]
    //UI面板
    public Image uiPanel;
    //血条slider
    public Slider hpSlider;
    //角色名字文本
    public Text nameText;
    //角色当前生命值数字
    public Text currentHPText;
    //台词背景面板
    public Image wordsPanel;
    /// 台词文本
    public Text wordsText;

    // Start is called before the first frame update
    void Start()
    {
        //UI初始化
        SetPlayerUI();
        //替身初始化
        SetPlayerStand();

        playerData.playerStand.GetComponent<StandFloat>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 设置角色UI需要显示的东西
    /// </summary>
    void SetPlayerUI()
    {
        //根据玩家站位调整图片朝向
        if(playerData.playerNo == PlayerNo.Player1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            //Debug.Log("没动时候"+playerWordsPos.position);
            playerWordsPos.position = transform.InverseTransformPoint(playerWordsPos.position);
            //Debug.Log("转成相对坐标" + playerWordsPos.position);
            playerWordsPos.position += new Vector3(-2*playerWordsPos.position.x, 0, 0);
            //Debug.Log("相对坐标偏移后" + playerWordsPos.position);
            playerWordsPos.position = transform.TransformPoint(playerWordsPos.position);
            //Debug.Log("转回没动时候" + playerWordsPos.position);
        }

        //设置脑袋上方的元素位置与标记物体位置一致, 由于是垂直中线对齐的, 不管左右站位 均不需要偏移
        uiPanel.transform.position = Camera.main.WorldToScreenPoint(playerUIPos.position);
        //设置对话框显示位置, 这个就需要偏移下了 正好用到了 之前我有疑惑的父子坐标问题
        wordsPanel.transform.position = Camera.main.WorldToScreenPoint(playerWordsPos.position);
        //设置生命值Slider最大值
        hpSlider.maxValue = playerData.shengMing;
        //设置生命值Slider当前值
        hpSlider.value = playerData.currentShengMing;
        //设置玩家名字
        nameText.text = playerData.mingZi;
        //设置生命值文本
        currentHPText.text = playerData.currentShengMing.ToString();
    }

    void SetPlayerStand()
    {
        playerData.playerStand.transform.position = playerStandPos.transform.position + playerData.playerStand.posOffSet;
        //playerData.playerStand.transform.parent = playerStandPos.transform;

        //GameObject playerStand = Instantiate(playerData.playerStand, playerStandPos);
        //根据玩家站位调整图片朝向
        if (playerData.playerNo == PlayerNo.Player1)
        {
            playerData.playerStand.GetComponent<SpriteRenderer>().flipX = true;
        }
    }


    //临时的说话方法
    public void SayWords(string words)
    {
        wordsText.gameObject.SetActive(true);
        wordsText.text = words;
        StartCoroutine(DelayHideObject(wordsPanel.gameObject));
    }

    //临时的隐藏方法
    IEnumerator DelayHideObject(GameObject ob)
    {
        yield return new WaitForSeconds(2);
        ob.SetActive(false);

    }

    //临时的攻击方法
    public void Attack(Player target)
    {
        playerData.playerStand.Attack(target);
    }
}
