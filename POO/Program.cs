

Beer erdingerBeer = new Beer()
{
    Name = "Erdinger",
    Price = 3
};

Console.WriteLine(erdingerBeer.Name);

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}