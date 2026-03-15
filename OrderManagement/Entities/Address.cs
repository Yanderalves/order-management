namespace OrderManagement.Entities;

public class Address
{
    public string Street { get; private set; }
    public string Number { get; private set; }
    public string? Complement { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }

    public Address(string street, string number, string? complement, string city, string state, string zipCode)
    {
        Street = street;
        Number = number;
        Complement = complement;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    private Address()
    {
        
    }
}