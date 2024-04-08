namespace APBD05.Models;

public class Visit(DateTime date, Animal? animal, string description, double price)
{
    public DateTime Date { get; set; } = date;
    public Animal? Animal { get; set; } = animal;
    public string Description { get; set; } = description;
    public double Price { get; set; } = price;
}
