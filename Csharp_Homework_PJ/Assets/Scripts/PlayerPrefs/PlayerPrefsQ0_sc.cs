using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsQ0_sc : MonoBehaviour
{
    private int _iSpaceTimes;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _iSpaceTimes = PlayerPrefs.GetInt("spacedown");
            _iSpaceTimes++;
            PlayerPrefs.SetInt("spacedown", _iSpaceTimes);
            print(PlayerPrefs.GetInt("spacedown") + "times");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _iSpaceTimes = 0;
            PlayerPrefs.SetInt("spacedown", _iSpaceTimes);
            print(PlayerPrefs.GetInt("spacedown") + "times");
        }
    }
    /*
     1. 玩家按下空白鍵(可以連續按)後畫面上的數字++
     2. 關閉遊戲
     3. 重開遊戲後，顯示的數字為上次關閉前的值
     4. 按下D清除數字的值
     */
}