using System;
using System.Collections.Generic;

public class Order{

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (Customer customer){

        _customer = customer;
    }

    public void AddProduct(Product product)
    {

        _products.Add(product);
    }

    public double ShippingCost()
    {
        if (_customer.LivesInUsa())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }
    
    public double CalculateTotalCost()
    {

        double total = 0;

        foreach (Product product in _products)
        {
            total += product.ComputeTotal();
        }
        total += ShippingCost();
        return total;
    }

    public string PackagingLable(){

        string label = "Packing label:\n";

        foreach (Product product in _products)
        {
            label += product.GetDisplayText() + "\n";
        }
        return label;
    }

    public string ShippingLabel(){

        return $"Shipping Label: \n {_customer.GetDisplayText()}";

    }

    public string DisplayText(){

        return $"Total cost: {CalculateTotalCost()}";
    }
}