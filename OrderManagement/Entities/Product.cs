namespace OrderManagement.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public bool IsActive { get; set; }
    
}