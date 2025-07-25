using System.Numerics;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _total;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotal()
    {
        foreach (Product product in _products)
        {
            _total += product.GetProductCost();
        }

        if (_customer.GetAddress().IsUSA()){_total += 5;}
        else{ _total += 35; }

        return _total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += ($"{product.GetName()} (ID: {product.GetProduct_id()}): {product.GetQuantity()} units \n");
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }
    
}