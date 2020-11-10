using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CityMenuScript : MonoBehaviour
{
    public Button travel, lookAround, productList, tip1, tip2, tip3, tip4;
    public GameObject tip1Art, tip2Art, tip3Art, tip4Art;
    public GameObject tip1ArtOpen, tip2ArtOpen, tip3ArtOpen, tip4ArtOpen;
    public GameObject productListWindow, lookAroundWindow;
    public Button inkeeper, villager, musician;
    public GameObject cityScene, dialogueScene;
    public GameObject paperTip;
    public string[] paperText;
    public TextMeshProUGUI paperTextValue;
    private int _paperNumber;
    public int npcNumber;

    void Start()
    {
        travel.onClick.AddListener(GoToTravel);
        lookAround.onClick.AddListener(OpenLookAround);
        productList.onClick.AddListener(OpenProductList);

        inkeeper.onClick.AddListener(Inkeeper);
        villager.onClick.AddListener(Villager);
        musician.onClick.AddListener(Musician);

        tip1.onClick.AddListener(delegate { Tip(0, true, false, false, false); });
        tip2.onClick.AddListener(delegate { Tip(1, false, true, false, false); });
        tip3.onClick.AddListener(delegate { Tip(2, false, false, true, false); });
        tip4.onClick.AddListener(delegate { Tip(3, false, false, false, true); });
    }

    void Update()
    {
        if (paperTip.activeSelf == true)
        {
            paperTextValue.text = paperText[_paperNumber];
        }
        else if (paperTip.activeSelf == false)
        {
            tip1Art.SetActive(true);
            tip2Art.SetActive(true);
            tip3Art.SetActive(true);
            tip4Art.SetActive(true);
        }
    }

    void GoToTravel()
    {
        Debug.Log("Tutaj pojawia się mapa");
    }

    void Inkeeper()
    {
        npcNumber = 2;
        dialogueScene.SetActive(true);
        cityScene.SetActive(false);
    }

    void Villager()
    {
        npcNumber = 1;
        dialogueScene.SetActive(true);
        cityScene.SetActive(false);
    }

    void Musician()
    {
        npcNumber = 0;
        dialogueScene.SetActive(true);
        cityScene.SetActive(false);
    }

    void Tip(int paperNumber, bool tip1, bool tip2, bool tip3, bool tip4)
    {
        _paperNumber = paperNumber;
        TipClose();
        if (tip1 == true)
        {
            tip1Art.SetActive(false);
            tip1ArtOpen.SetActive(true);
        }

        if (tip2 == true)
        {
            tip2Art.SetActive(false);
            tip2ArtOpen.SetActive(true);
        }
        if (tip3 == true)
        {
            tip3Art.SetActive(false);
            tip3ArtOpen.SetActive(true);
        }
        if (tip4 == true)
        {
            tip4Art.SetActive(false);
            tip4ArtOpen.SetActive(true);
        }
        dialogueScene.SetActive(false);
    }

    void TipClose()
    {
        paperTip.SetActive(true);
        tip1Art.SetActive(true);
        tip2Art.SetActive(true);
        tip3Art.SetActive(true);
        tip4Art.SetActive(true);
        tip1ArtOpen.SetActive(false);
        tip2ArtOpen.SetActive(false);
        tip3ArtOpen.SetActive(false);
        tip4ArtOpen.SetActive(false);
    }

    void OpenLookAround()
    {
        lookAroundWindow.SetActive(true);
        productListWindow.SetActive(false);
    }

    void OpenProductList()
    {
        productListWindow.SetActive(true);
        lookAroundWindow.SetActive(false);
    }
}
