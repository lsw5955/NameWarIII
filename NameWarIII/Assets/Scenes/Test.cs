using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    //上一帧鼠标位置
    float lastMousePosY;

    float lastFrameMousePositonY;

    public ParticleSystem ps;

    private void Awake()
    {
        lastMousePosY = Input.mousePosition.y;
    }

    private void Start()
    {
        Debug.Log(Screen.currentResolution);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
        }
        if(Input.GetAxis("Mouse Y") != 0)
        {
            Debug.Log("上一帧Y : " + lastMousePosY + "这一帧Y : " + Input.mousePosition.y + "GetAxis返回值 : " + Input.GetAxis("Mouse Y"));
            Debug.Log("这一帧-上一帧/游戏分辨率高度 * 100 = " + (Input.mousePosition.y - lastMousePosY) / (Screen.currentResolution.height/100));
        }
        lastMousePosY = Input.mousePosition.y;


    }


}
