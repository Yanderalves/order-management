namespace OrderManagement.Entities;
// A entidade Customer possui os campos: Id (Guid), Name (string, obrigatório), Email (string, único, obrigatório), Phone (string), CreatedAt (DateTime).
public class Customer
{
    public Customer(Guid id, string name, string email, string phone, DateTime createdAt)
    {
        Id = id;
        Name = name;
        Email = email;
        Phone = phone;
        CreatedAt = createdAt;
    }

    private Customer()
    {
        
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime CreatedAt { get; set; }
}