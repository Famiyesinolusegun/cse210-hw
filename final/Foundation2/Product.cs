public class Product
{
    private string _product;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string product, int productId, double price, int quantity)
    {
        _product = product;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public override string ToString()
    {
        return $"product: {_product}, Product ID: {_productId}, Price: ${_price}, Quantity: {_quantity}";
    }

}
