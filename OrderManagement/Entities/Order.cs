using OrderManagement.Enums;

namespace OrderManagement.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public Customer Customer { get; private set; }
    public Guid CustomerId { get; private set; }
    public OrderStatus Status { get; private set; }
    public decimal TotalAmount { get; private set; }
    public decimal Discount { get; private set; }
    public decimal FinalAmount { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public Address DeliveryAddress { get; private set; }
    public List<OrderItem> OrderItems { get; private set; }

    public Order(OrderStatus status, decimal totalAmount, decimal discount, decimal finalAmount, DateTime createdAt, DateTime updatedAt)
    {
        Status = OrderStatus.Pending;
        TotalAmount = totalAmount;
        Discount = discount;
        FinalAmount = finalAmount;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}