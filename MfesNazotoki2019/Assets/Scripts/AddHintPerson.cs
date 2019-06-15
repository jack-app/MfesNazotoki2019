using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddHintPerson : MonoBehaviour
{
    public Text SeenPerson;
    // Start is called before the first frame update
    void Start()
    {
        SeenPerson.text = "2人が視聴中";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
