using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine;

public class Lambda_sc : MonoBehaviour
{
    public delegate void NoReturnNoPara();

    public delegate void NoReturnWithPara(int x, string s);

    private void Start()
    {
        {
            NoReturnNoPara r = new NoReturnNoPara(DoNothing);
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

    class lambda1
    {
        //Func就是接收然後回傳，最後一個是回傳的屬性
        //todo: 如何在Func傳入int輸出string呢?
        string GetResult(Func<string, string> f)
        {
            string s = "ZAZA";

            return f(s);
        }

        void Main(string[] args)
        {
            Console.WriteLine(GetResult(GetStr));
        }

        string GetStr(string str)
        {
            return str + "is dont";
        }
    }

    class lambda2
    {
        string GetResult(Func<string, string> f)
        {
            string s = "ZAZA";
            return f(s);
        }

        void Main()
        {
            print(GetResult(delegate(string str) { return str + "is dont"; }));
        }
    }

    class lambda3
    {
        string GetResult(Func<string, string> f)
        {
            string s = "ZAZA";
            return f(s);
        }

        void Main()
        {
            print(GetResult(( str) => { return str + "is dont"; }));
        }
    }

    class lambda4
    {
        string GetResult(Func<string, string> f)
        {
            string s = "ZAZA";
            return f(s);
        }

        void Main()
        {
            Console.WriteLine(GetResult(str => str + "is dont"));
        }
    }

    class lambda5
    {
        void One()
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
                actionprams += new Action<string, string>(getstring);


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
    }
}