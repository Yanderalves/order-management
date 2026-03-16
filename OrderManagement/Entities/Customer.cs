namespace OrderManagement.Entities;
public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public DateTime CreatedAt { get; set; }

    public Customer(string name, string email, string? phone, DateTime createdAt)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Phone = phone;
        CreatedAt = DateTime.Now;
    }
}