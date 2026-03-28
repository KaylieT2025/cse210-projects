using System;

public class Product{

    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product( string name, string productId, double price, int quantity){

        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double ComputeTotal(){

        return _price * _quantity;
    }

    public string GetDisplayText(){

        return $"{_quantity} {_name} {_productId} - {_price}";
    }
}