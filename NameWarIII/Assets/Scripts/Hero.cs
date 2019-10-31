using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hero
{
    public int MaxHp { get; set; }
    public int Power { get; set; }
    public int Accuarcy { get; set; }
    public int Dodge { get; set; }
    public string Name { get; set; }
    internal string Occupation { get; set; }

    public virtual void BornWords()
    {
        Debug.Log("["+ Name +"]擦了擦身上的泥土, 发现自己已经变成了一名["+Occupation+"]");
    }

    public virtual void Skill1()
    {

    }
}
