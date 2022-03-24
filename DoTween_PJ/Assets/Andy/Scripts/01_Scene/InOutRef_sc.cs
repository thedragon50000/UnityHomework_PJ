// using System;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace ParameterModifier
{
    /*
    out：入參只需宣告，不需初始化參數。方法內必須給定入參的值。只能修飾變數(常數值與方法、委派皆不可用)，方法執行完成後，將修改入參的值。若要傳回複數資料 C#7.0後建議使用 tuple
    ref：傳遞參數的位址。入參需初始化參數，方法內可以不調整入參值。只能修飾變數(常數值與方法、委派皆不可用)
    in：C#7.2新增。傳遞參數的位址。入參不允許修改。
     */

    public class InOutRef_sc : MonoBehaviour
    {
        public void Start()
        {
            Main(null);
        }

        #region Out

        // class testClass
        // {
        //     public string x = "";
        // }
        //
        // static void Main(string[] args)
        // {
        //     testClass obj; //out 參數使用時，僅需宣告，不需初始化
        //     string x = "1234";
        //     Fun_out(x, out obj);
        //     print(obj.x); //方法結束後便可使用被設定為out 的入參
        // }
        //
        // static void Fun_out(string x, out testClass otherobj)
        // {
        //     otherobj = new testClass(); //out 參數不論傳入時是否已經實作，必定要在方法內重新實作
        //     otherobj.x = x;
        // }

        #endregion

        #region Ref

        // class testClass
        // {
        //     public string x = "";
        // }
        //
        // static void Main(string[] args)
        // {
        //     testClass obj;
        //     obj = new testClass(); //ref 參數使用時，需初始化
        //
        //     string x = "444";
        //     Fun_out(x, ref obj);
        //     Debug.Log(obj.x);
        // }
        //
        // static void Fun_out(string x, ref testClass otherobj)
        // {
        //     //方法內不強迫要重新實作ref 參數
        //     otherobj.x = x;
        // }

        #endregion

        #region In

        class parentClass
        {
            public string x = "";
        }

        class sonClass : parentClass
        {
        }

        static void Main(string[] args)
        {
            var pObj = new parentClass();
            var obj = new sonClass();


            string x = "Son Of pObj";
            string px = "Parent";

            Fun_out(x, obj); //當入參不輸入in修飾詞，表示允許方法嘗試將延伸類別轉換成基底類別
            Fun_out(px, in pObj); //當入參輸入in修飾詞，表示要直接參考入參，故型別需一致
            print("obj:" + obj.x);
            print("pObj:" + pObj.x);
        }

        static void Fun_out(string x, in parentClass otherobj)
        {
            // otherobj = new prentClass(); //不可重新實作入參
            otherobj.x = x; //僅有物件本身為唯獨，物件內的屬性不受影響，因為是不同的參考位址
        }

        #endregion
    }
}