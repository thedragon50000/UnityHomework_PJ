using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class Generic_In_n_Out : MonoBehaviour
{
    #region Out

    // interface IObject<out A>
    // {
    //     string typeOf();
    // }
    //
    // class samlpe<A> : IObject<A>
    // {
    //     string IObject<A>.typeOf()
    //     {
    //         return typeof(A).ToString();
    //     }
    // }
    //
    // class samlpeB<A> : IObject<A>
    // {
    //     string IObject<A>.typeOf()
    //     {
    //         return typeof(A).ToString();
    //     }
    // }
    //
    // static void Main(string[] args)
    // {
    //     IObject<object> _object = new samlpe<Object>();
    //     IObject<string> _string = new samlpeB<String>();
    //     _object = _string; //可以轉換成父型別
    // }

    #endregion

    #region In

    // interface IObject<in A>
    // {
    //     string typeOf();
    // }
    //
    // class samlpe<A> : IObject<A>
    // {
    //     string IObject<A>.typeOf()
    //     {
    //         return typeof(A).ToString();
    //     }
    // }
    //
    // class samlpeB<A> : IObject<A>
    // {
    //     string IObject<A>.typeOf()
    //     {
    //         return typeof(A).ToString();
    //     }
    // }
    //
    //
    // static void Main(string[] args)
    // {
    //     IObject<object> _object = new samlpe<System.Object>();  //todo:注意UnityEngine.Object跟 object是不同類型
    //     IObject<object> _object2 = new samlpe<object>();
    //     IObject<string> _string = new samlpeB<String>();
    //     _string = _object; //可以轉換成子型別
    //     _string = _object2;
    // }

    #endregion

    #region Func

    void Main(string[] args)
    {
        //方法test 雖然規定傳入object a回傳string
        //但Func 允許隱含轉換，因此可以傳入string 回傳object
        Func<object, string> testFunc = test;
        object yy = testFunc("");
    }

    string test(object a)
    {
        return "";
    }

    #endregion
}