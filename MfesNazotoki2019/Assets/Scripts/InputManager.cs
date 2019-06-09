using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    InputField inputField;
    public string inputValue;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        InitInputField();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InputLogger()
    {
        inputValue = inputField.text;
        //Debug.Log(inputValue);
        InitInputField();
    }


    public void InitInputField()
    {
        //値をリセット
        inputField.text = "";

        //フォーカス
        inputField.ActivateInputField();
    }
}
