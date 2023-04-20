using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public abstract class CharacterData_sc : MonoBehaviour
{
    protected string Name;
    protected float Atk;
    protected float Hp;

    public virtual void Skill1()
    {
        print("技能1");
    }

    public virtual void Skill2()
    {
        print("技能2");
    }

    public virtual void Skill3()
    {
        print("技能3");
    }

    public virtual void Skill4()
    {
        print("技能4");
    }
}