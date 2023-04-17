using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senshi_sc : CharacterData_sc
{
    public Senshi_sc()
    {
        _name = "魔法戰士";
        _atk = 50;
        _hp = 100;
    }
    public override void Skill1()
    {
        print("劈斬");
    }

    public override void Skill2()
    {
        print("防禦");
    }

    public override void Skill3()
    {
        print("火球");
    }

    public override void Skill4()
    {
        print("治癒");
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}