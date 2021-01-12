using Dialogue_System.Nodes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dialogue_System
{
    public class DialogueTest : MonoBehaviour
    {
        public DialogueGraph dialogue;
        private Chat _currentChat;

        [Header("Dialouge Objects")] 
        public TextMeshProUGUI npcText;
        public Button answerButton;
    
        void Start()
        {
            dialogue.Restart();
            _currentChat = dialogue.current as Chat;
            print(_currentChat.text);

            npcText.text = _currentChat.text;
            answerButton.GetComponentInChildren<TextMeshProUGUI>().text = _currentChat.answers[1];
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
            _currentChat = dialogue.current as Chat;
            _currentChat.AnswerQuestion(answerIndex);
            _currentChat = dialogue.current as Chat;
            print(_currentChat.text);
            npcText.text = _currentChat.text;
            answerButton.GetComponentInChildren<TextMeshProUGUI>().text = _currentChat.answers[0];
        }
    }
}
