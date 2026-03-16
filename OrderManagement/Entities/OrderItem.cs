namespace OrderManagement.Entities;

public class OrderItem
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice  { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public OrderItem(string productName, decimal unitPrice, int quantity, decimal totalPrice, DateTime createdAt, DateTime updatedAt)
    {
        Id = Guid.NewGuid();
        ProductName = productName;
        UnitPrice = unitPrice;
        Quantity = quantity;
        TotalPrice = totalPrice;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}