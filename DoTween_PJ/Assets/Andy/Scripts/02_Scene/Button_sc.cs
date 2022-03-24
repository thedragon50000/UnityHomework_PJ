using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Button_sc : MonoBehaviour
{
    public RectTransform panelTransform;

    private bool isIn = false;

    void Start()
    {
        //默认动画播放完成会被销毁
        //Tweener对象保存这个动画的信息 每次调用do类型的方法都会创建一个tweener对象，这个对象是dotween来管理
        Tweener tweener = panelTransform.DOLocalMove(new Vector3(0, 0, 0), 0.3f);

        tweener.SetAutoKill(false); // 把autokill 自动销毁设置为false
        tweener.Pause(); //暂停动画,使其一开始不播放

        // gameObject.GetComponent<Button>().onClick.AddListener(() =>
        // panelTransform.DOLocalMove(new Vector3(0, 0, 0), 1));

        gameObject.GetComponent<Button>().onClick.AddListener(() =>
        {
            switch (isIn)
            {
                case false:
                    panelTransform.DOPlayForward(); //前放
                    isIn = true;
                    break;
                default:
                    //让panel离开屏幕
                    panelTransform.DOPlayBackwards(); //倒放
                    isIn = false;
                    break;
            }
        });

        // Update is called once per frame
        void Update()
        {
        }
    }
}