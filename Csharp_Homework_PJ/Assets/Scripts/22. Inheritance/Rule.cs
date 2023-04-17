using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule
{
  /*
   * -----------------------------------------------------------------------
<<<非耦合>>>
建構Class(BaseData22.cs)基本資料腳本
string _name
float _atk
float _hp

<<<低耦合>>>
建構Class(WarriorScript.cs)戰士腳本 : 繼承 (BaseData.cs)基本資料腳本
方法 Void Skill1(); 印出 "劈斬"
方法 Void Skill2(); 印出 "防禦"

建構Class(MageScript.cs)法師腳本 : 繼承 (BaseData.cs)基本資料腳本
方法 Void Skill1(); 印出 "火球"
方法 Void Skill2(); 印出 "治癒"

建構Class(MageWarriorScript.cs)魔法騎士腳本 : 繼承 (BaseData.cs)基本資料腳本
方法 Void Skill1(); 印出 "劈斬"
方法 Void Skill2(); 印出 "防禦"
方法 Void Skill3(); 印出 "火球"
方法 Void Skill4(); 印出 "治癒"


<<<耦合>>>
建構Class(PlayerScript1.cs)玩家腳本 : 繼承 (WarriorScript.cs)戰士腳本
按下鍵盤
Q - 執行 方法 Void Skill1(); 印出 "劈斬"
W - 執行 方法 Void Skill2(); 印出 "防禦"

建構Class(PlayerScript2.cs)玩家腳本 : 繼承 (MageScript.cs)法師腳本
按下鍵盤
Q - 執行 方法 Void Skill1(); 印出 "火球"
W - 執行 方法 Void Skill2(); 印出 "治癒"

建構Class(PlayerScript3.cs)玩家腳本 : 繼承 (MageWarriorScript.cs)魔法騎士腳本
按下鍵盤
Q - 執行 方法 Void Skill1(); 印出 "劈斬"
W - 執行 方法 Void Skill2(); 印出 "防禦"
E - 執行 方法 Void Skill3(); 印出 "火球"
R - 執行 方法 Void Skill4(); 印出 "治癒"
   */
}
