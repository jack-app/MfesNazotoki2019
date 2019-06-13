using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    //ゲーム進行用フラグ
    static public int flag = 0;
    public GameObject[] Text;
    //正誤判定フラグ
    static public int answer = 0;
    //画面張るやつ
    public GameObject Cube;
    //Sceneの画面遷移
    public Material[] Scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(answer == 1)
        {
            GameManager();
            answer = 0;
        }

    }

    void GameManager()
    {
        if (flag<Text.Length)
        {
            switch (flag)
            {
                case (0):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    break;
                case (1):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    break;
                case (2):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (3):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (4):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    break;
                case (5):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (6):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (7):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    break;
                case (8):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (9):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    break;
                case (10):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (11):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (12):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (13):
                    Text[flag].SetActive(false);
                    //Text[flag + 1].SetActive(true);
                    break;
            }
            flag += 1;
        }

    }
}
