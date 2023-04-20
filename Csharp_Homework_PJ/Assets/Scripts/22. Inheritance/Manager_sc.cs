using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_sc : MonoBehaviour
{
    private BaseData_sc _player;
    public EPlayerClass e;

    // Start is called before the first frame update
    void Start()
    {
        switch (e)
        {
            case EPlayerClass.Warrior:
                _player = new Player_sc();
                break;
            case EPlayerClass.Mage:
                _player = new Player2_sc();
                break;
            case EPlayerClass.MageWarrior:
                _player = new Player3_sc();
                break;
        }

        print(_player.strClass);
        print(_player.atk);
        print(_player.hp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _player.Skill1();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _player.Skill2();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _player.Skill3();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _player.Skill4();
        }
    }
}

public class Player_sc : WarriorData_sc
{
}

public class Player2_sc : MageData_sc
{
}

public class Player3_sc : MageWarriorData_sc
{
}

public enum EPlayerClass
{
    Warrior,
    Mage,
    MageWarrior,
    MAX
}