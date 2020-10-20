using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New City", menuName = "City")]
public class City : ScriptableObject
{
    public string cityName;
    public string description;
    public int[] resources = new int[3];
    public Image cityImage;
    public Color cityColor;

    public void Print()
    {
        
    }
}
