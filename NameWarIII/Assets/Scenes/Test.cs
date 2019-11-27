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

    }

    void OnParticleSystemStopped()
    {
        Debug.Log("试试");
    }

}
