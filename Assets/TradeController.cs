using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TradeController : MonoBehaviour
{
    public GameObject productPrefab;
    [SerializeField] private TextMeshProUGUI cityNameText;

    [SerializeField] private GameObject productListParent;

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
        foreach (Product product in products)
        {
            TradeProductController newProduct = Instantiate(productPrefab, productListParent.transform).GetComponent<TradeProductController>();
            
            newProduct.priceText.text = $"{product.price.ToString()}$";
            newProduct.merchantAmount.text = $"x{product.amount.ToString()}";
            newProduct.productNameText.text = product.productType.ToString();
            newProduct.productIcon.sprite = Database.GetProductIcon(product);

            newProduct.playerAmountText.text = $"x{Database.GetPlayerEq().Products[product.productType].ToString()}";
        }

        _productsGenerated = true;
    }
}
