using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEditor.PackageManager.Requests;
using UnityEngine.UI;

public class Practice_Lambda_with_DoTween : MonoBehaviour
{
    /*Tweener：补间动画
        Sequence：相当于一个Tweener的链表，可以通过执行一个Sequence来执行一串Tweener
        Tween：Tweener + Sequence
        Nested tween：Sequence中的一个Tweener称为一个Nested tween

    主要的方法(就是最常用的)：

        1.以DO开头的方法：就是补间动画的方法。例如：transform.DOMoveX(100,1)

    2.以Set开头的方法：设置补间动画的一些属性。例如：myTween.SetLoops(4, LoopType.Yoyo)

    3.以On开头的方法：补间动画的回调方法。例如：myTween.OnStart(myStartFunction)*/

    public Vector3 myValue = new Vector3(0, 0, 0);
    public Transform cubeTransform;
    public RectTransform taskPanelTransform; //创建RectTransform组件,并要在Unity中拖拽赋值

    public int istart;
    public Text txt;

    void Start()
    {
        // DOTween.To(() => istart, x => istart = x, 0, 2);
        // DOTween.To(() => myValue, x => myValue = x, new Vector3(0, 0, 0), 4);
        istart = 100;
        Lambda_void_for_DoTween();

    }
    void Update()
    {
        txt .text = istart.ToString();
        // print(istart);
    }
    private void Lambda_void_for_DoTween()
    {
        //1.需有一個專門服務的方法，通常就只在這呼叫而且「只呼叫一次」

        void SetInt(int progressive)
        {
            istart = progressive;
        }

        int GetInt()
        {
            return istart;
        }

        DOGetter<int> getter = new DOGetter<int>(GetInt);
        DOSetter<int> setter = SetInt;

        // DOTween.To(getter, setter, 0, 2.5f);
        // DOTween.To(getter, y => istart = y, 0, 2.5f);
        DOTween.To(GetInt, delegate(int i) { setter(i); }, 0, 2.5f);
        // DOTween.To(getter, SetInt, 0, 2.5f);
    }


    void LamdaTest()
    {
        #region 一些搞懂Lamda到底在寫啥的測試，有演變方式

        //DOTween.To 的固定寫法，這裡以int為例
        DOTween.To(() => istart, x => istart = x, 0, 2);


        /*
        To需要的參數有以下四個：

        (DOGetter<Vector3> getter,
        DOSetter<Vector3> setter,
        Vector3 endValue,
        float duration)

        DOGetter、DOSetter是delegate
        DOGetter因為是泛型<T>所以給什麼屬性就out什麼屬性

        */

        {
        }

        {
            //2.所以就有了新的寫法，直接寫在委託裡，並自動生成隱藏的方法名(開發者不用命名了)
            DOGetter<Vector3> getter = delegate()
            {
                Vector3 x = myValue;
                return x;
            };
            DOTween.To(getter, y => new Vector3(0, 0, 0), Vector3.zero, 2.5f);
        }

        {
            //3.演化成Lamda表達式
            DOGetter<Vector3> getter = () => myValue;
            DOTween.To(getter, y => new Vector3(0, 0, 0), Vector3.zero, 2.5f);
        }
        {
            //4.進一步簡化 todo:為什麼不能直接給myValue
            Vector3 Getter() => myValue;
            DOTween.To((DOGetter<Vector3>) Getter, y => new Vector3(0, 0, 0), Vector3.zero, 2.5f);
        }

        #endregion
    }

    class OutExample
    {
        void GetV3(out Vector3 v3)
        {
            v3 = Vector3.left;
        }

        void MainGet()
        {
            Vector3 vv;
            GetV3(out vv);
        }
    }
}