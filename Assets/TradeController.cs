using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TradeController : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public GameObject productPrefab;
    [SerializeField] private TextMeshProUGUI cityNameText;

    [SerializeField] private GameObject productListParent;

    private List<TradeProductController> _tradeProductControllers;
    
    private bool _productsGenerated;

    public void Show(City city)
    {
        gameObject.SetActive(true);
        cityNameText.text = city.cityName;

        if (_productsGenerated) return;
        GenerateProducts(city.resources);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void GenerateProducts(List<Product> products)
    {
        _tradeProductControllers = new List<TradeProductController>();
        foreach (Product product in products)
        {
            TradeProductController newProduct = Instantiate(productPrefab, productListParent.transform).GetComponent<TradeProductController>();
            newProduct.Product = product;
            newProduct.Initialize();
            newProduct.OnBuy += Buy;
            newProduct.OnSell += Sell;
            _tradeProductControllers.Add(newProduct);
        }

        _productsGenerated = true;
    }

    private void Buy(TradeProductController tradeProductController)
    {
        Product product = tradeProductController.Product;
        PlayerEquipment playerEq = Database.GetPlayerEq();
        playerEq.RemoveGold(product.price);
        playerEq.AddProduct(product.productType, 1);
        product.amount -= 1;
        goldText.text = playerEq.Gold.ToString();
        foreach (TradeProductController productController in _tradeProductControllers) productController.Initialize();
    }
    
    private void Sell(TradeProductController tradeProductController)
    {
        Product product = tradeProductController.Product;
        PlayerEquipment playerEq = Database.GetPlayerEq();
        playerEq.AddGold(product.price);
        playerEq.RemoveProduct(product.productType, 1);
        product.amount += 1;
        goldText.text = playerEq.Gold.ToString();
        foreach (TradeProductController productController in _tradeProductControllers) productController.Initialize();
    }
}
