using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TradeProductController : MonoBehaviour
{
    private Product _product;

    public Product Product
    {
        get => _product;
        set => _product = value;
    }

    public TextMeshProUGUI priceText, merchantAmount, playerAmountText, productNameText;
    public Image productIcon;
    public Button buyButton, sellButton;

    public Action<TradeProductController> OnBuy, OnSell;

    public void Initialize()
    {
        priceText.text = $"{_product.price.ToString()}$";
        merchantAmount.text = $"x{_product.amount.ToString()}";
        productNameText.text = _product.productType.ToString();
        productIcon.sprite = Database.GetProductIcon(_product);

        playerAmountText.text = $"x{Database.GetPlayerEq().Products[_product.productType].ToString()}";

        buyButton.interactable = _product.amount > 0 && Database.GetPlayerEq().Gold >= _product.price;
        sellButton.interactable = Database.GetPlayerEq().Products[_product.productType] > 0;
    }
    
    public void Buy()
    {
        print("Buy from trade product");
        OnBuy.Invoke(this);
    }

    public void Sell()
    {
        print("Sell from trade product");
        OnSell.Invoke(this);
    }
}
