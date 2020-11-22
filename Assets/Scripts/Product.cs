using System;

[Serializable]
public class Product
{
    public Products productType;
    public int amount, price;
}

public enum Products
{
    WOOD,
    STONE,
    FLOUR
}