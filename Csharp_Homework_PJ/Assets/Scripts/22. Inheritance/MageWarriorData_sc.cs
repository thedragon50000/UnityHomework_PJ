using UnityEngine;

public class MageWarriorData_sc : BaseData_sc
{
    public MageWarriorData_sc()
    {
        strClass = "魔法戰士";
        atk = 80;
        hp = 80;
    }

    public override void Skill1()
    {
        print(strClass + "劈斬" + atk + "點傷害");
    }

    public override void Skill2()
    {
        print(strClass + "防禦");
    }

    public override void Skill3()
    {
        print($"火球，{atk}點傷害");
    }

    public override void Skill4()
    {
        print($"治癒，回復{atk * 0.7f}");
    }
}