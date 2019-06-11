using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    GameObject inputField;
    GameObject scrollView;
    InputManager InputManager;
    Transform parentTransform;
    public GameObject RoomNode;
    public GameObject Content;


    // Start is called before the first frame update
    void Start()
    {
        inputField = GameObject.Find("InputField");
        scrollView = GameObject.Find("Scroll View");



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        //Scroll Viewのサイズの取得
        RectTransform rectTransform = scrollView.GetComponent<RectTransform>();
        //Debug.Log(rectTransform.rect.width);
        //Debug.Log(rectTransform.rect.height);
        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;
        //Debug.Log(width);
        //Debug.Log(height);


        //入力内容の取得
        InputManager = inputField.GetComponent<InputManager>();
        InputManager.InputLogger();

        string inputText = InputManager.inputValue;
        //Debug.Log(inputText);


        //コメントが入力されていたら表示
        if (inputText != "")
        {
            GameObject prefab = Instantiate(RoomNode);
            prefab.transform.parent = Content.transform;

            //RoomNodeのサイズ調整
            prefab.GetComponent<RectTransform>().localScale = new Vector3((float)1.3, (float)1.3, 1);                              


            prefab.transform.Find("Text").GetComponent<Text>().text = inputText;
        }
        
    }
}
