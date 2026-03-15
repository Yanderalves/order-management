namespace OrderManagement.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public bool IsActive { get; set; }

    public Product(string name, decimal unitPrice, bool isActive)
    {
        Id = Guid.NewGuid();
        Name = name;
        UnitPrice = unitPrice;
        IsActive = isActive;
    }

    private Product()
    {
        
    }
}