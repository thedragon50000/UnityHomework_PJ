using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsQ1_sc : MonoBehaviour
{
    public Sprite[] arySprite = new Sprite[3];

    public Image imgShow;

    public Button[] aryBtn = new Button[3];

    void Start()
    {
        imgShow.sprite = arySprite[PlayerPrefs.GetInt("imgnumber")];

        for (int i = 0; i < aryBtn.Length; i++)
        {
            int temp = i;
            aryBtn[i].onClick.AddListener(delegate
            {
                imgShow.sprite = arySprite[PlayerPrefs.GetInt("imgnumber")];
                PlayerPrefs.SetInt("imgnumber", temp);
            });
        }
    }
}
/*下方三個按鈕(Button)，上方一個圖片顯示(Image)

選擇按鈕後將其選擇的圖案顯示於上方Image。

遊戲停止執行(關閉運作) = > 重新開啟後 => 上方Image顯示之前所選擇的圖片(有記憶儲存)。*/