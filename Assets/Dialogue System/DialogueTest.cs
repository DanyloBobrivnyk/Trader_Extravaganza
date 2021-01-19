using System.Linq;
using Dialogue_System.Nodes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dialogue_System
{
    public class DialogueTest : MonoBehaviour
    {
        public CityMenuScript cityMenuScript;
        public DialogueGraph dialogue;
        private Chat _currentChat;

        [Header("Dialouge Objects")] 
        public TextMeshProUGUI npcText;

        public GameObject answersParent;
        public GameObject answerButtonPrefab;

        void Start()
        {
            dialogue.dialogueController = this;
            dialogue.Restart();
            _currentChat = dialogue.current as Chat;
            GenerateUI();
        }

        public void AnswerQuestion(int answerIndex)
        {
            _currentChat = dialogue.current as Chat;
            _currentChat.AnswerQuestion(answerIndex);
            _currentChat = dialogue.current as Chat;
            GenerateUI();
        }

        public void GenerateUI()
        {

            foreach (Transform t in answersParent.transform)
            {
                Destroy(t.gameObject);
            }
            npcText.text = _currentChat.text;
            
            for (var index = 0; index < _currentChat.answers.Count; index++)
            {
                int tmp = index;
                Button answerButton = Instantiate(answerButtonPrefab, answersParent.transform).GetComponent<Button>();
                answerButton.GetComponentInChildren<TextMeshProUGUI>().text = _currentChat.answers[tmp];
                answerButton.onClick.AddListener(() => { AnswerQuestion(tmp); print(tmp); });
            }
        }

        public void EndDialogue()
        {
            gameObject.SetActive(false);
            cityMenuScript.cityScene.SetActive(true);
        }
    }
}
