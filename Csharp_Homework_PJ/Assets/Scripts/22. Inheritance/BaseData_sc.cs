using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseData_sc : MonoBehaviour
{
    public string _name;

    public float _atk;

    public float _hp;



    // public BaseData_sc(string pName, int Atk, int Hp)
    // {
    //     _name = pName;
    //     _atk = Atk;
    //     _hp = Hp;
    // }

    /*
     建構Class(BaseData.cs)基本資料腳本
     string _name
     float _atk
     float _hp

     建構Class(WarriorData.cs)戰士腳本
     方法 Void Skill1(); 印出 "劈斬"
     方法 Void Skill2(); 印出 "防禦"

     建構Class(MageData.cs)法師腳本
     方法 Void Skill1(); 印出 "火球"
     方法 Void Skill2(); 印出 "治癒"
     */
}