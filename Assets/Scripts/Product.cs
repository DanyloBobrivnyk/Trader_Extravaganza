using System;
using UnityEngine;

[Serializable]
public class Product
{
    public ProductTypes productType;
    public int amount, price;
}

public enum ProductTypes
{
    GRAIN,
    LEATHER,
    MEAT,
    SPICES,
    WOOD
}