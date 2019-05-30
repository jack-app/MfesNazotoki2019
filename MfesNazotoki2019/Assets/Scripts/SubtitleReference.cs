using System.Collections;
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
            //現在表示している文字数
            int textcount = 0;
            //一時的に置いておく用
            string tmptext = "";
            while (text[i].Length > textcount)
            {
                if (textcount % 47 != 46)
                {
                    tmptext += text[i][textcount] ;
                }
                else
                {
                    tmptext += text[i][textcount] + "\n           ";

                }
                Subtitle.text = "itoka「" + tmptext + "」";
                textcount++;
                yield return new WaitForSeconds(secondtime);

            }
            i += 1;
        }
        active = true;

    }
}
