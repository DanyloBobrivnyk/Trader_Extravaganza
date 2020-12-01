using System.Collections;
using System.Collections.Generic;
using Tips;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CityMenuScript : MonoBehaviour
{
    public int cityID;
    private City _city;
    [SerializeField] private TipsController _tipsController;
    public GameObject lookAroundWindow;
    [SerializeField] private TradeController _tradeController;
    public Button inkeeper, villager, musician;
    public GameObject cityScene, dialogueScene;
    private int _paperNumber;
    public int npcNumber;

    void Start()
    {
        print("CityMenu start");
        _city = Database.GetCity(cityID);
        _tipsController.SetMessages(Database.GetCityPapersMessages(cityID));

        inkeeper.onClick.AddListener(Inkeeper);
        villager.onClick.AddListener(Villager);
        musician.onClick.AddListener(Musician);
    }

    public void GoToTravel()
    {
        Debug.Log("Tutaj pojawia się mapa");
    }
    
    public void OpenLookAround()
    {
        lookAroundWindow.SetActive(true);
    }

    public void OpenProductList()
    {
        _tradeController.Show(_city);
        lookAroundWindow.SetActive(false);
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

    
}
