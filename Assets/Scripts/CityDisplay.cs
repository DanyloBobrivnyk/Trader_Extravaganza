using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CityDisplay : MonoBehaviour
{
   public City city;
   public TextMeshProUGUI nameText;
   public TextMeshProUGUI descriptionText;
   public Image artworkImage;
    void Start()
    {
        nameText.text = city.cityName;
        descriptionText.text = city.description;
        //artworkImage.sprite = example sprite
        Debug.Log(nameText);
    }
}
