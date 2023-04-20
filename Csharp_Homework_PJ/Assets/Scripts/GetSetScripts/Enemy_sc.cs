using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Enemy_sc : MonoBehaviour
{
    private int _hp;

    public int Hp
    {
        get => _hp;
        private set
        {
            _hp = value;
            if (_hp <= 0)
            {
                _hp = 0;
            }
        }
    }

    public string enemyName;

    public void Injured(int damage)
    {
        Hp -= damage;
    }

    public Enemy_sc(EenemyType e)
    {
        print("new Enemy");
        switch (e)
        {
            case EenemyType.雜魚:
                _hp = 50;
                enemyName = e.ToString();
                break;

            case EenemyType.菁英:
                _hp = 100;
                enemyName = e.ToString();

                break;

            case EenemyType.四天王:
                _hp = 500;
                enemyName = e.ToString();

                break;
        }
    }
}

public enum EenemyType
{
    雜魚,
    菁英,
    四天王
}