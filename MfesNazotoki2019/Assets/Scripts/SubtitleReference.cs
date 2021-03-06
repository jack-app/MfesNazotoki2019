﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleReference : MonoBehaviour
{
    //表示部分
    public Text Subtitle;
    //表示背景
    public GameObject Panel;
    //表示フレーム
    public float secondtime;
    //登場人物
    public bool[] remark;
    //表示する文章
    public string[] text;
    //文章の順番カウント用
    private int i = 0;
    //コルーチンのオンオフ判定用
    private bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        Subtitle.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //エンターキーを押すと
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (active == true)
            {
                active = false;
                StartCoroutine("SubtitleMove");
            }
        }
    }
    /// <summary>
    /// 文章を一文字ずつ表示します。
    /// </summary>
    private IEnumerator SubtitleMove()
    {
        if (i < text.Length)
        {
            //初期化
            Subtitle.text = "";
            //背景色変更
            Panel.GetComponent<Image>().color = new Color(225f / 255f, 225f / 255f, 225f / 255f, 128f / 255f);
            //現在表示している文字数+1
            int textcount = 0;
            //文字のバイト数を確認する
            float bytecount = 0;
            //一時的に置いておく用
            string tmptext = "";
            while (text[i].Length > textcount)
            {
                tmptext += text[i][textcount] ;
                Subtitle.text = "" + tmptext + "";
                //textをchar型に変更してバイト数を判定→バイト数をbytecountに追加
                char chartext = text[i][textcount];
                if (IsChar2Byte(chartext))
                {
                    //実際の全角と半角の比を考えて1ではなくて0.8バイトで計算
                    bytecount+=0.8f;
                }
                bytecount++;
                if(bytecount >= 80)
                {
                    tmptext += "\n";
                    bytecount = 0;
                }
                textcount++;
                yield return new WaitForSeconds(secondtime);

            }
            if (remark[i]==true)
            {
                //ここにコメント欄にも同じコメントが流れるようなコードを描く
            }
            i += 1;
        }
        else
        {
            //初期化
            Subtitle.text = "";
            //背景色変更
            Panel.GetComponent<Image>().color = new Color(225f / 255f, 225f / 255f, 225f / 255f, 0f / 255f);
        }
        active = true;

    }
    /// <summary>
    /// 文字が全角なら true を、半角なら false を返します
    /// </summary>
    public static bool IsChar2Byte(char c)
    {
        return !((c >= 0x0 && c < 0x81) || (c == 0xf8f0) || (c >= 0xff61 && c < 0xffa0) || (c >= 0xf8f1 && c < 0xf8f4));
    }
}
