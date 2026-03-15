namespace OrderManagement.Entities;

public class Order
{
    public Guid Id { get; set; }
    public Customer Customer { get; set; }
    public Guid CustomerId { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal Discount { get; set; }
    public decimal FinalAmount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Address DeliveryAddress { get; set; }

    public Order(Guid id, decimal totalAmount, decimal discount, decimal finalAmount, DateTime createdAt, DateTime updatedAt, Address deliveryAddress)
    {
        Id = id;
        TotalAmount = totalAmount;
        Discount = discount;
        FinalAmount = finalAmount;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        DeliveryAddress = deliveryAddress;
    }

    private Order()
    {
        
    }
}