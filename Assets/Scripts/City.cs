using System.Collections;
using System.Collections.Generic;
using Tips;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New City", menuName = "City")]
public class City : ScriptableObject
{
    public string cityName;
    public string description;
    public Sprite cityImage;
    
    public List<Product> resources;

    public List<Paper> papers;

    public List<Dialog> dialogs;
    //public Color cityColor;

    public void Print()
    {
        
    }
}
