using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public InputField nameInputField;

    public void DoATest()
    {
        Warrior w = new Warrior();
        w.Name = nameInputField.text;
        w.BornWords();
    }
}
