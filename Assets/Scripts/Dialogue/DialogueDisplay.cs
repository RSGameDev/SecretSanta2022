using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDisplay : MonoBehaviour
{
    public Dialogue dialogue;

    public TextMeshProUGUI message;
    // Start is called before the first frame update
    void Start()
    {
        message.text = dialogue.message;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
