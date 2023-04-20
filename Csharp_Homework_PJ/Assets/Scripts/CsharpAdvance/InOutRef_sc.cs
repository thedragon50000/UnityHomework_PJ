// using System;

using UnityEngine;

namespace ParameterModifier
{
    /*
    out：入參只需宣告，不需初始化參數。方法內必須給定入參的值。只能修飾變數(常數值與方法、委派皆不可用)，
        方法執行完成後，將修改入參的值。若要傳回複數資料 C#7.0後建議使用 tuple
    ref：傳遞參數的位址。入參需初始化參數，方法內可以不調整入參值。只能修飾變數(常數值與方法、委派皆不可用)
    in：C#7.2新增。傳遞參數的位址。入參不允許修改。
     */

    public class InOutRef_sc : MonoBehaviour
    {
        #region Private Variables

        private class ParentClass
        {
            #region Public Variables

            public string x = "";

            #endregion
        }

        private class SonClass : ParentClass
        {
        }

        #endregion

        #region Unity events

        public void Start()
        {
            Main1(null);
            Main2(null);
            Main3(null);
        }

        #endregion

        #region Private Methods

        private static void Fun_in(string x, in ParentClass otherObj)
        {
            // otherObj = new ParentClass(); //不可重新實作入參
            otherObj.x = x; //僅有物件本身為唯獨，物件內的屬性不受影響，因為是不同的參考位址
        }

        private static void Main1(string[] args)
        {
            var pObj = new ParentClass();
            var obj = new SonClass();

            var x = "Son Of pObj";
            var px = "Parent";

            Fun_in(x, obj); //當入參不輸入in修飾詞，表示允許方法嘗試將延伸類別轉換成基底類別
            Fun_in(px, in pObj); //當入參輸入in修飾詞，表示要直接參考入參，故型別需一致
            print("obj:" + obj.x);
            print("pObj:" + pObj.x);
        }

        #endregion

        class TestClass
        {
            public string x = "";
        }

        static void Main2(string[] args)
        {
            TestClass obj; //out 參數使用時，僅需宣告，不需初始化
            string x = "1234";
            Fun_out(x, out obj);
            print(obj.x); //方法結束後便可使用被設定為out 的入參
        }

        static void Fun_out(string x, out TestClass otherobj)
        {
            //out 參數不論傳入時是否已經實作，必定要在方法內重新實作
            otherobj = new TestClass
            {
                x = x
            };
        }

        class testClassRef
        {
            public string x = "";
        }
        
        static void Main3(string[] args)
        {
            testClassRef obj;
            obj = new testClassRef(); //ref 參數使用時，需初始化
        
            string x = "444";
            Fun_Ref(x, ref obj);
            Debug.Log(obj.x);
        }
        
        static void Fun_Ref(string x, ref testClassRef otherobj)
        {
            //方法內不強迫要重新實作ref 參數
            otherobj.x = x;
        }
    }
}