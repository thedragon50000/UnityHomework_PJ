using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsQ1_sc : MonoBehaviour
{
    public Sprite[] img_ary = new Sprite[3];

    public Image imgShow;


    public Button[] btn_ary = new Button[3];

    // Start is called before the first frame update
    void Start()
    {
        imgShow.sprite = img_ary[PlayerPrefs.GetInt("imgnumber")];

        for (int i = 0; i < btn_ary.Length; i++)
        {
            int temp = i;
            btn_ary[i].onClick.AddListener(delegate
            {
                PlayerPrefs.SetInt("imgnumber", temp);
                imgShow.sprite = img_ary[PlayerPrefs.GetInt("imgnumber")];
            });

        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}