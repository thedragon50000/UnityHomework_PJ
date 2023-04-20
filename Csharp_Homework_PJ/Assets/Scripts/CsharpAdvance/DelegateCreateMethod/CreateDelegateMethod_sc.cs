using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CreateDelegateMethod_sc
{
    public static List<int> AndyWhere(this List<int> t, Func<int, bool> func)
    {
        List<int> iList = new List<int>();
        foreach (var i in t)
        {
            if (func.Invoke(i))
            {
                iList.Add(i);
            }
        }

        return iList;
    }
}