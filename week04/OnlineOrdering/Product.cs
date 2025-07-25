using System.Dynamic;

class Product
{
    string _name;
    string _product_id;
    double _price;
    int _quantity;

    public Product(string name, string product_id, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _product_id = product_id;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProduct_id()
    {
        return _product_id;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetProductCost()
    {
        return _price * _quantity;
    }

}