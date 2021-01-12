using System.Collections;
using System.Collections.Generic;
using Tips;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New City", menuName = "Cities/City")]
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

    public void Test(string test) {}
    public void ChangeProductPrice(ProductTypes productType, int changeAmount)
    {
        foreach (Product product in resources)
        {
            if (product.productType == productType) product.price += changeAmount;
        }
    }
}

[CreateAssetMenu(fileName = "Current City", menuName = "Cities/Current City")]
public class CurrentCity : City
{
    public City city;
}
