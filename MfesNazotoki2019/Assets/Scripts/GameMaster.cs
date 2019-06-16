using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    //ゲーム進行用フラグ
    static public int flag = 0;
    public GameObject[] Text;
    public GameObject[] Repeat;
    public GameObject[] Hint;
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
        if (answer == -2)
        {
            RepeatQuiz();
            answer = 0;
        }
        //
        if (answer == -1)
        {
            HintQuiz();
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
                    Cube.GetComponent<Renderer>().material = Scene[flag];
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
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (14):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    Cube.GetComponent<Renderer>().material = Scene[flag];
                    break;
                case (15):
                    Text[flag].SetActive(false);
                    Text[flag + 1].SetActive(true);
                    SceneManager.LoadScene("Title");
                    break;
            }
            flag += 1;
        }

    }
    void RepeatQuiz()
    {
        switch (flag)
        {
            case (1):
                Repeat[flag].SetActive(true);
                break;
            case (4):
                Repeat[flag].SetActive(true);
                break;
            case (7):
                Repeat[flag].SetActive(true);
                break;
            case (9):
                Repeat[flag].SetActive(true);
                break;
        }
    }
    //
    void HintQuiz()
    {
        switch (flag)
        {
            case (1):
                Hint[flag].SetActive(true);
                break;
            case (4):
                Hint[flag].SetActive(true);
                break;
            case (7):
                Hint[flag].SetActive(true);
                break;
            case (9):
                Hint[flag].SetActive(true);
                break;
        }
    }
}
