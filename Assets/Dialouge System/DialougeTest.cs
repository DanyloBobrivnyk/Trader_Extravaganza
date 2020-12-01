using System.Collections;
using System.Collections.Generic;
using Dialouge_System;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class DialougeTest : MonoBehaviour
{
    public SimpleGraph dialouge;
    private Chat chat;

    [Header("Dialouge Objects")] 
    public TextMeshProUGUI npcText;
    public Button answerButton;
    
    void Start()
    {
        dialouge.Restart();
        chat = dialouge.current as Chat;
        print(chat.text);

        npcText.text = chat.text;
        answerButton.GetComponentInChildren<TextMeshProUGUI>().text = chat.answers[1];
        answerButton.onClick.AddListener(() => { AnswerQuestion(1); });
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            AnswerQuestion(0);
        }
    }

    public void AnswerQuestion(int answerIndex)
    {
        print("Answering question");
        chat = dialouge.current as Chat;
        chat.AnswerQuestion(answerIndex);
        chat = dialouge.current as Chat;
        print(chat.text);
        npcText.text = chat.text;
        answerButton.GetComponentInChildren<TextMeshProUGUI>().text = chat.answers[0];
    }
}
