using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorData_sc : BaseData_sc
{
    public WarriorData_sc()
    {
        _name = "戰士";
        _atk = 50;
        _hp = 100;
    }

    public void Skill1()
    {
        print(_name + "劈斬" + _atk + "點傷害");
    }

    public void Skill2()
    {
        print(_name + "防禦，血量還剩" + _hp);
    }
}
