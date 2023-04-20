using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senshi_sc : CharacterData_sc
{
    public Senshi_sc()
    {
        Name = "魔法戰士";
        Atk = 50;
        Hp = 100;
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