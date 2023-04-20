using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

public class Practice_Lambda_with_DoTween : MonoBehaviour
{
    #region Public Variables

    public int iStart;
    public Text txt;

    public Vector3 myValue = new Vector3(0, 0, 0);

    #endregion

    #region Private Variables

    private class OutExample
    {
        #region Private Methods

        private void GetV3(out Vector3 v3)
        {
            v3 = Vector3.left;
        }

        private void MainGet()
        {
            Vector3 vv;
            GetV3(out vv);
        }

        #endregion
    }

    #endregion

    #region Unity events

    private void Start()
    {
        DOTween.To(() => iStart, x => iStart = x, 0, 2);
        DOTween.To(() => myValue, x => myValue = x, new Vector3(0, 0, 0), 4);
        iStart = 100;
        Lambda_void_for_DoTween();
    }

    #endregion

    #region Private Methods

    private void Lambda_void_for_DoTween()
    {
        //1.需有一個專門服務的方法，通常就只在這呼叫而且「只呼叫一次」

        void SetInt(int progressive)
        {
            iStart = progressive;
        }

        int GetInt()
        {
            return iStart;
        }

        DOGetter<int> getter = GetInt;
        DOGetter<int> getter2 = GetInt;

        DOSetter<int> setter = SetInt;

        DOTween.To(getter, setter, 0, 2.5f);
        DOTween.To(getter2, y => iStart = y, 0, 2.5f);

        //int i是DoTween.To一直在算的值，每次改iStart的值就是new一個i讓iStart = i
        DOTween.To(GetInt, delegate(int i) { setter(i); }, 0, 2.5f);
        DOTween.To(GetInt, delegate(int i) { SetInt(i); }, 0, 2.5f);
        DOTween.To(getter, SetInt, 0, 2.5f);
    }


    private void LamdaTest()
    {
        #region 一些搞懂Lamda到底在寫啥的測試，有演變方式

        //DOTween.To 的固定寫法，這裡以int為例
        DOTween.To(() => iStart, x => iStart = x, 0, 2);


        /*
        To需要的參數有以下四個：

        (DOGetter<Vector3> getter,
        DOSetter<Vector3> setter,
        Vector3 endValue,
        float duration)

        DOGetter、DOSetter是delegate
        DOGetter是委託+泛型<T>，給什麼屬性就out什麼屬性

        */
        
        {
            //2.所以就有了新的寫法，直接寫在委託裡，並自動生成隱藏的方法名(開發者不用命名了)
            DOGetter<Vector3> getter = delegate
            {
                var x = myValue;
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
            Vector3 Getter()
            {
                return myValue;
            }

            DOTween.To(Getter, y => new Vector3(0, 0, 0), Vector3.zero, 2.5f);
        }

        #endregion
    }

    private void Update()
    {
        txt.text = iStart.ToString();
    }

    #endregion
}