using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorData_sc : BaseData_sc
{
    public WarriorData_sc()
    {
        strClass = "戰士";
        atk = 50;
        hp = 100;
    }

    public override void Skill1()
    {
        print(strClass + "劈斬" + atk + "點傷害");
    }

    public override void Skill2()
    {
        print(strClass + "防禦");
    }
}