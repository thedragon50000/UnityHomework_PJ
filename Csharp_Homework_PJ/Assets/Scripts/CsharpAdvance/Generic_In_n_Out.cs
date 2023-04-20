using System;
using UnityEngine;

// using Object = System.Object;

public class Generic_In_n_Out : MonoBehaviour
{
    private void Start()
    {
        // Main1();
        Main2();
        // Main3();
    }

    #region 隱含轉換

    private void Main1()
    {
        //方法test 雖然規定傳入object a，回傳string
        //但Func 允許隱含轉換，因此可以傳入string

        Func<object, string> testFunc = Test;
        object yy = Test(5);
        var s = Test(5);

        print("yy的類型" + yy.GetType());
        print("s的類型" + s.GetType());
    }

    private string Test(object i)
    {
        return "A";
    }

    #endregion

    #region Out

    interface IObject2<out TA>
    {
        string TypeOf();
    }

    private class Sample<TA> : IObject2<TA>
    {
        string IObject2<TA>.TypeOf()
        {
            return typeof(TA).ToString();
        }
    }

    private class SampleB<TA> : IObject2<TA>
    {
        string IObject2<TA>.TypeOf()
        {
            return typeof(TA).ToString();
        }
    }

    static void Main2()
    {
        IObject2<object> _object = new Sample<UnityEngine.Object>();
        IObject2<string> _string = new SampleB<String>();
        print("_object的類型:" + _object.GetType());
        print("_string的類型:" + _string.GetType());
        _object = _string; //可以轉換成父型別
        print("可以轉換成父型別，轉換之後的_object的類型:" + _object.GetType());
    }

    #endregion

    #region In

    interface IObject<in TA>
    {
        string TypeOf();
    }

    private class Sample2<TA> : IObject<TA>
    {
        string IObject<TA>.TypeOf()
        {
            return typeof(TA).ToString();
        }
    }

    private class Sample2B<TA> : IObject<TA>
    {
        string IObject<TA>.TypeOf()
        {
            return typeof(TA).ToString();
        }
    }


    static void Main3()
    {
        IObject<object> _object = new Sample2<System.Object>();
        IObject<string> _string = new Sample2B<String>();

        //todo:注意UnityEngine.Object跟 System.Object是不同類型
        // IObject<object> _object2 = new Sample2<UnityEngine.Object>();
        
        print("_object的類型" + _object.GetType());
        print("_string的類型" + _string.GetType());
        
        _string = _object; //可以轉換成子型別(把object轉string)
        print("可以轉換成父型別，轉換之後的_object的類型" + _object.GetType());
        
    }

    #endregion
}