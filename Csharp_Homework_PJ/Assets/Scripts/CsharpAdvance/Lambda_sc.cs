using System;
using UnityEngine;

public class Lambda_sc : MonoBehaviour
{
    #region Private Variables

    private class lambda1
    {
        #region Private Methods

        //Func就是接收然後回傳，最後一個是回傳的屬性
        //todo: 如何在Func傳入int輸出string呢?
        //Ans: 給他一個string XXX(int i){return i.ToString();}之類的
        private string GetResult(Func<string, string> f)
        {
            var s = "ZAZA";

            return f(s);
        }

        private string GetStr(string str)
        {
            return str + "is dont";
        }

        private void Main(string[] args)
        {
            Console.WriteLine(GetResult(GetStr));
        }

        #endregion
    }

    private class lambda2
    {
        #region Private Methods

        private string GetResult(Func<string, string> f)
        {
            var s = "ZAZA";
            return f(s);
        }

        private void Main()
        {
            print(GetResult(delegate(string str) { return str + "is dont"; }));
        }

        #endregion
    }

    private class lambda3
    {
        #region Private Methods

        private string GetResult(Func<string, string> f)
        {
            var s = "ZAZA";
            return f(s);
        }

        private void Main()
        {
            print(GetResult(str => { return str + "is dont"; }));
        }

        #endregion
    }

    private class lambda4
    {
        #region Private Methods

        private string GetResult(Func<string, string> f)
        {
            var s = "ZAZA";
            return f(s);
        }

        private void Main()
        {
            Console.WriteLine(GetResult(str => str + "is dont"));
        }

        #endregion
    }

    private class lambda5
    {
        #region Events

        private void One()
        {
            {
                //无返回值 无参数
                //void getstring(){Console.WriteLine("xxx")}
                Action action = () => Console.WriteLine("xxx");
                action();
            }

            {
                //无返回值 一个参数  void getstring(string str){Console.WriteLine(str)}
                Action<string> actionpram = s => Console.WriteLine(s);
                actionpram("SayWhat?");
            }

            {
                //无返回值 多个参数
                void getstring(string s, string d)
                {
                    Console.WriteLine($"第一个参数{s},第二个参数{d}");
                }

                Action<string, string> actionprams = null;
                actionprams += getstring;


                // Action<string, string> actionprams = (s, d) => Console.WriteLine($"第一个参数{s},第二个参数{d}");
                actionprams("what up", "say Hi!");
            }

            {
                //有返回值 无参数
                //DateTime getDate(){return DateTime.Now;}
                Func<DateTime> fnc = () => DateTime.Now;
            }

            {
                //有返回值 一个参数
                // DateTime getDate(string time){return Convert.ToDateTime(s);}
                Func<string, DateTime> fn = s => Convert.ToDateTime(s);
            }

            {
                //有返回值 多个参数
                // string getString(int a,int b){return (a+b).ToString();}
                Func<int, int, string> fncc = (i1, i2) => (i1 + i2).ToString();
            }
        }

        #endregion
    }

    #endregion

    #region Unity events

    private void Start()
    {
        {
            NoReturnNoPara r = DoNothing;
        }
        {
            NoReturnNoPara r = delegate { print("Test2"); };
        }
        {
            NoReturnNoPara r = () => print("Test3");
        }
        {
            NoReturnWithPara r2 = (x, s) => print(x + "" + s);
        }

        void DoNothing()
        {
            print("Test1");
        }
    }

    #endregion

    #region Delegates

    public delegate void NoReturnNoPara();

    public delegate void NoReturnWithPara(int x, string s);

    #endregion
}