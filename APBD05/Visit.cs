using APBD05.Models;

namespace APBD05;

public class Visit
{
    public DateTime Date { get; set; }
    public Animal Animal { get; set; }
    public string description { get; set; }
    public double price { get; set; }
}
