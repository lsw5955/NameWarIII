using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    Test A;
    Test B;

    string name;

    private void Start()
    {
        A = new Test();
        B = new Test();
        A.name = "A";
        B.name = "B";
        Experiment(A);
        Experiment(ref A);
        
    }

    void Experiment(Test exp)
    {
        exp = B;
        Debug.Log("没有Ref exp=B后, exp.name是" + (exp.name) + "||A.name是" + A.name + "||A这个符号代表的实例的地址值没变化");    
    }

    void Experiment(ref Test exp)
    {
        exp = B;
        Debug.Log("但是加了有Ref exp=B后, exp.name是" + (exp.name) + "||A.name是" + A.name + "||A这个符号代表的实例的地址值已经变成了B的地址值");
    }

}
