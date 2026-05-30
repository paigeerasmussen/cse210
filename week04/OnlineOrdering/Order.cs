using System;

class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalPrice()
    {
        decimal cost = 0;
        decimal shippingCost = 0;

        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        foreach (Product product in _products)
        {
            cost += product.TotalCost();
        }

        cost += shippingCost;
        return cost;
    }

    public string PackagingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label = $"{label}{product.GetDisplayText()}\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return _customer.GetDisplayText();
    }
}