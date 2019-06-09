using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    GameObject inputField;
    InputManager InputManager;
    Transform parentTransform;
    public GameObject RoomNode;
    public GameObject Content;


    // Start is called before the first frame update
    void Start()
    {
        inputField = GameObject.Find("InputField");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        InputManager = inputField.GetComponent<InputManager>();
        InputManager.InputLogger();
        GameObject prefab = Instantiate(RoomNode);
        prefab.transform.parent = Content.transform;


        string inputText = InputManager.inputValue;
        Debug.Log(inputText);

        prefab.transform.Find("Text").GetComponent<Text>().text = inputText;
    }
}
