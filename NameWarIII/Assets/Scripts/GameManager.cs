using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public InputField nameInputField1;
    public InputField nameInputField2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(nameInputField1.text);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(nameInputField2.text);
        }
    }
}
