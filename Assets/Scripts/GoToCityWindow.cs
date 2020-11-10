using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoToCityWindow : MonoBehaviour
{
    public GameObject CityScene, DialogueScene;
    public GameObject yesNoObject, nextButton, tips;
    public Button yes, no, next;
    private int textIndex = 0;
    public int npcNumbertoChoose;

    public string[] inkeeperDialogues, villagerDialogues, musicianDialogues;
    public TextMeshProUGUI DialogueTextBox;
    public CityMenuScript partner;

    void Start()
    {
        // Wartości startowe
        yesNoObject.SetActive(false);
        nextButton.SetActive(true);
        textIndex = 0;

        // Pobieram z którym NPC rozmawiam
        npcNumbertoChoose = partner.GetComponent<CityMenuScript>().npcNumber;

        // Dany npc wyświetla pierwszą linijkę
        if(npcNumbertoChoose == 0)
            DialogueTextBox.text = musicianDialogues[0];
        else if (npcNumbertoChoose == 1)
            DialogueTextBox.text = villagerDialogues[0];
        else if (npcNumbertoChoose == 2)
            DialogueTextBox.text = inkeeperDialogues[0];

        // Dodaję listenery
        yes.onClick.AddListener(delegate { Back(1); });
        no.onClick.AddListener(delegate { Back(2); });

        // Guzik next ma przypisaną wartość w zależności od wybranego NPCta.
        if (npcNumbertoChoose == 0)
            next.onClick.AddListener(delegate { Next(npcNumbertoChoose); });
        else if (npcNumbertoChoose == 1)
            next.onClick.AddListener(delegate { Next(npcNumbertoChoose); });
        else if (npcNumbertoChoose == 2)
            next.onClick.AddListener(delegate { Next(npcNumbertoChoose); });
    }

    void OnEnable()
    {
        yesNoObject.SetActive(false);
        nextButton.SetActive(true);
        textIndex = 0;
        npcNumbertoChoose = partner.GetComponent<CityMenuScript>().npcNumber;

        if (npcNumbertoChoose == 0)
            DialogueTextBox.text = musicianDialogues[0];
        else if (npcNumbertoChoose == 1)
            DialogueTextBox.text = villagerDialogues[0];
        else if (npcNumbertoChoose == 2)
            DialogueTextBox.text = inkeeperDialogues[0];
    }

    void Back(int yesOrNo)
    {
        //Który NPC? Zresetuj wartość text boxa
        if (npcNumbertoChoose == 0)
            DialogueTextBox.text = inkeeperDialogues[0];
        else if (npcNumbertoChoose == 1)
            DialogueTextBox.text = villagerDialogues[0];
        else if (npcNumbertoChoose == 2)
            DialogueTextBox.text = musicianDialogues[0];

        // Jeśli tak
        if (yesOrNo == 1)
        {
            textIndex = 0;
            CityScene.SetActive(true);
            tips.SetActive(true);
            yesNoObject.SetActive(false);
            nextButton.SetActive(true);
            DialogueScene.SetActive(false);
        }

        // Jeśli nie
        if (yesOrNo == 2)
        {
            textIndex = 0;
            CityScene.SetActive(true);
            yesNoObject.SetActive(false);
            nextButton.SetActive(true);
            DialogueScene.SetActive(false);
        }
    }

    void Next(int targetNpc)
    {
        textIndex++;

        if (targetNpc == 2)
        {
            if (textIndex < inkeeperDialogues.Length)
            {
                DialogueTextBox.text = inkeeperDialogues[textIndex];
            }
            else
            {
                yesNoObject.SetActive(true);
                nextButton.SetActive(false);
            }
        }
        else if (targetNpc == 1)
        {
            if (textIndex < villagerDialogues.Length)
            {
                DialogueTextBox.text = villagerDialogues[textIndex];
            }
            else
            {
                yesNoObject.SetActive(true);
                nextButton.SetActive(false);
            }
        }
        else if (targetNpc == 0)
        {
            if (textIndex < musicianDialogues.Length)
            {
                DialogueTextBox.text = musicianDialogues[textIndex];
            }
            else
            {
                yesNoObject.SetActive(true);
                nextButton.SetActive(false);
            }
        }
    }
}
