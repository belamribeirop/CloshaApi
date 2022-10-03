namespace Domain.Entities;
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public StatusType Status { get; set; }
    public NegociationType NegociationType { get; set; }
    public CategoryType Category { get; set; }
    public string Image { get; set; }
    public IEnumerable<string> Tags { get; set; }
    public int OwnerId { get; set; }

}
public enum CategoryType { }
public enum NegociationType { Sale, Rent }
public enum StatusType { Avaliable, Unavailable }