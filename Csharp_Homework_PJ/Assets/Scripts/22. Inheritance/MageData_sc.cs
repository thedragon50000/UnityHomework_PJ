using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageData_sc : BaseData_sc
{
    public override void Skill1()
    {
        print($"火球，{atk}點傷害");
    }

    public override void Skill2()
    {
        print($"治癒，回復{atk * 0.7f}");
    }

    public MageData_sc()
    {
        strClass = "法師";
        atk = 100;
        hp = 50;
    }
}