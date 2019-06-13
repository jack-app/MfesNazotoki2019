using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;



public class AnswerCheckScript : MonoBehaviour
{

    //Inspectorに複数データを表示するためのクラス
    
    [System.SerializableAttribute]
    public class ValueList
    {
        public List<string> List = new List<string>();

        public ValueList(List<string> list)
        {
            List = list;
        }
    }
    
   // [SerializeField]
   // private List<int> _valueList;

    //Inspectorに表示される
    [SerializeField]
    private List<ValueList> correctAnswerList = new List<ValueList>();


    public string answer;
   
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        int questionNumber = GameMaster.flag;
        answer = ButtonController.inputText;
        int c = Check(questionNumber, answer);
        GameMaster.answer = c;
    }


    //引数は　問題番号(0スタート), 入力したこたえ
    public int Check(int questionNumber, string answer)
    {
        //わからないと聞かれたら-1を返す
        if(Regex.Match(answer, "わからない").Success)
        {
            return -1;
        }
        //correctAnswerList[questionNumber] = "a";
        for (int i = 0;i < correctAnswerList[questionNumber].List.Count; i++)
        {

            Match match = Regex.Match(answer, correctAnswerList[questionNumber].List[i]);

            if (match.Success)
            {
                //合ってたら1を返す
                return 1;
            }

            /*
            if(answer == correctAnswers[i])
            {
                return true;
            }*/
        }
        //間違ってたら0を返す
        return 0;
    }
}

