using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyAndProducts : MonoBehaviour
{
    public TextMeshProUGUI[] productAmountUGUIText;
    public int[] productAmmount;

    public TextMeshProUGUI[] productValueUGUIText;
    public int[] productValue;

    public TextMeshProUGUI goldAmmount;
    public int goldValue;

    [Range(0, 20)]
    public Slider[] slider;

    public int[] lastIntSliderValue;

    public Dictionary<ProductTypes, string> products;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            lastIntSliderValue[i] = 0;
            productValue[i] = UnityEngine.Random.Range(1, 4);
            productValueUGUIText[i].text = productValue[i].ToString();
        }

        slider[0].onValueChanged.AddListener((value) => {
            MakeMoney(0, value);
        });
        slider[1].onValueChanged.AddListener((value) => {
            MakeMoney(1, value);
        });
        slider[2].onValueChanged.AddListener((value) => {
            MakeMoney(2, value);
        });
        slider[3].onValueChanged.AddListener((value) => {
            MakeMoney(3, value);
        });
        slider[4].onValueChanged.AddListener((value) => {
            MakeMoney(4, value);
        });
    }
    
    void MakeMoney(int i, float value)
    {
        Debug.Log(i);
        // sprzedawanie
        if (lastIntSliderValue[i] > (int)value)
        {
            goldValue += productValue[i];
            goldAmmount.text = goldValue.ToString();
            productAmmount[i]--;
            lastIntSliderValue[i] = (int)value;
            productAmountUGUIText[i].text = ((int)slider[i].value).ToString();
        }
        // kupowanie
        else if (lastIntSliderValue[i] < (int)value)
        {
            if (goldValue >= productValue[i])
            {
                goldValue -= productValue[i];
                goldAmmount.text = goldValue.ToString();
                productAmmount[i]++;
                lastIntSliderValue[i] = (int)value;
                productAmountUGUIText[i].text = ((int)slider[i].value).ToString();
            }
            else
            {
                slider[i].value = lastIntSliderValue[i];
                productAmountUGUIText[i].text = ((int)slider[i].value).ToString();
            }
        }
    }
}
