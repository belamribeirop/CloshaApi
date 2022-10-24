namespace Domain.Entities;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Telephone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public DateTime BirthDate { get; set; }
    public string Neighborhood { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string PhotoUrl { get; set; }
}