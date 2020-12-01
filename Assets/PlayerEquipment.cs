using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    public int Gold { get; private set; }

    public Dictionary<ProductTypes, int> Products { get; private set; }

    public void AddGold(int amount)
    {
        Gold += amount;
    }

    public void RemoveGold(int amount)
    {
        Gold -= amount;
        if (Gold < 0) Gold = 0;
    }

    public void AddProduct(ProductTypes type, int amount)
    {
        Products[type] = amount;
    }

    public void RemoveProduct(ProductTypes type, int amount)
    {
        Products[type] = amount;
        if (Products[type] < 0) Products[type] = 0;
    }

    public void Start()
    {
        Gold = 100;
        Products = new Dictionary<ProductTypes, int>
        {
            {ProductTypes.MEAT, 5},
            {ProductTypes.WOOD, 6},
            {ProductTypes.GRAIN, 7},
            {ProductTypes.SPICES, 8},
            {ProductTypes.LEATHER, 9},
        };
    }
}
