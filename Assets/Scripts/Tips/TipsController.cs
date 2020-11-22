using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Tips
{
    public class TipsController : MonoBehaviour
    {
        [SerializeField] private Sprite openedPaper, closedPaper;
        [SerializeField] private GameObject paperPrefab;
        [SerializeField] private GameObject papersParent, messagePanel;
        [SerializeField] private TextMeshProUGUI messageText;
        public List<string> _messages;

        private void Start()
        {
            print("TipsController start");
            foreach (string message in _messages)
            {
                GameObject paper = Instantiate(paperPrefab, papersParent.transform);
                paper.GetComponent<Button>().onClick.AddListener(() => { ShowTip(message); });
            }
            
            gameObject.SetActive(false);
        }

        public void SetMessages(List<string> messages)
        {
            print("TipsController setting messages");
            _messages = messages;
        }

        public void ShowTip(string message)
        {
            messagePanel.SetActive(true);
            messageText.text = message;
        }

        public void HideTip()
        {
            messagePanel.SetActive(false);
        }
    }
}
