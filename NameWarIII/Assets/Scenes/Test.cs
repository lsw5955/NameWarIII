using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{ 
    int a;
    bool isOk;

    private void Start()
    {
        a = 10;
        Test b;//= this;
        TestFun(out b);
        Debug.Log(b.a);
    }

    void TestFun(out Test x)
    {
        x = new Test();
        x.a = 1000;
    }
}
