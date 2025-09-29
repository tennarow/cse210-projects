public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on address
        if (_customer.GetAddress().IsInUSA())
        {
            total += 5; // Flat rate for USA
        }
        else
        {
            total += 35; // Flat rate for international
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()}) - Quantity: {product.GetQuantity()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        var address = _customer.GetAddress().GetFullAddress();
        return $"Shipping Label:\n{_customer.GetName()}\n{address}";
    }
}