﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 玩家各种数据与显示的初始化
/// </summary>
public class SettingPlayer : MonoBehaviour
{
    //角色数据
    public Scb_PlayerData playerData;
    //角色头顶UI位置标记物体
    public Transform playerUIPos;
    //角色替身显示位置
    public Transform playerStandPos;

    [Header("UI elements")]
    //UI面板
    public Image uiPanel;
    //血条slider
    public Slider hpSlider;
    //角色名字文本
    public Text nameText;
    //角色当前生命值数字
    public Text currentHPText;

    // Start is called before the first frame update
    void Start()
    {
        //UI初始化
        SetPlayerUI();
        //替身初始化
        SetPlayerStand();
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
        }

        uiPanel.transform.position = Camera.main.WorldToScreenPoint(playerUIPos.position);
        hpSlider.maxValue = playerData.shengMing;
        hpSlider.value = playerData.currentShengMing;
        nameText.text = playerData.mingZi;
        currentHPText.text = playerData.currentShengMing.ToString();
    }

    void SetPlayerStand()
    {
        playerData.playerStand.transform.position = playerStandPos.transform.position;
        playerData.playerStand.transform.parent = playerStandPos.transform;

        //GameObject playerStand = Instantiate(playerData.playerStand, playerStandPos);
        //根据玩家站位调整图片朝向
        if (playerData.playerNo == PlayerNo.Player1)
        {
            playerData.playerStand.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
