using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class DelegateMethod_sc : MonoBehaviour
{
    public List<int> iList = new List<int> {1, 2, 3, 4};
    
    private void Start()
    {
        List<int> i = new List<int> {1, 2, 3, 7, 5};
        var j = i.AndyWhere(Than);
        print("Than的結果:");
        foreach (var i1 in j)
        {
            print(i1);
        }

        print("Than2的結果:");
        j = i.AndyWhere(Than2);
        foreach (var i1 in j)
        {
            print(i1);
        }

        bb b = isBigger;

        ThanNull = i1 => b(i1);
        ThanNull = isBigger;
        ThanNull.Invoke(1);


        #region 很帥的寫法

        var list = from i2 in iList
            where i2 < 4
            select new
            {
                LessThan4 = i2
            };

        #endregion
    }
    
    /*
    不能再簡了，如果只寫DeThan，還要再多寫更多Func<int, bool>讓他加，是沒有意義的

    private delegate Func<int, bool> DeThan(int i);
    像這樣，給她一個Func<int,bool>
    private DeThan _dd;
    _dd += i1 => Than.Invoke;
    */

    readonly Func<int, bool> Than = delegate(int i) { return i < 3; };

    readonly Func<int, bool> Than2 = n => n >= 3;
    
    private Func<int, bool> ThanNull;

    private delegate bool bb(int i);

    bb Smaller = i => i <= 3;

    bool isBigger(int i)
    {
        return i > 0;
    }
}