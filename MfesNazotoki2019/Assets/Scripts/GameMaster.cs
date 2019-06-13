using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    //ゲーム進行用フラグ
    private int flag = 0;
    public GameObject[] Text;
    static public bool answer =false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(answer == true)
        {
            GameManager();
            answer = false;
        }

    }

    void GameManager()
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
                break;
            case (3):
                Text[flag].SetActive(false);
                Text[flag + 1].SetActive(true);
                break;
        }
        flag += 1;
    }
}
