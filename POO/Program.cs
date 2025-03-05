using POO.Bussines;

Beer erdingerBeer = new Beer("Erdinger", 3, -2, 1000);

var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024,12,01), 330);

//Drink drink = new Beer("Erdinger", 3, -2, 1000);

/*
Drink drink = new Wine(500);
Show(drink);
drink = new Beer("Corona", 2, 4, 330);
Show(drink);
Show(erdingerBeer);
*/
var service = new Service(100, 10);

ISalable[] concepts = [
    erdingerBeer,
    delirium,
    service
    ];

Console.WriteLine(GetTotal(concepts));

var elements = new Collection<int>(3);
elements.Add(100);
elements.Add(150);
elements.Add(200);
elements.Add(500);
foreach (var element in elements.Get())
{
    Console.WriteLine(element);
}

var names = new Collection<string>(2);
names.Add("Hector");
names.Add("Ana");
names.Add("Juan");
foreach (var element in names.Get())
{
    Console.WriteLine(element);
}

var beers = new Collection<Beer>(2);
beers.Add(erdingerBeer);
beers.Add(delirium);

foreach (var element in  beers.Get())
{
    Console.WriteLine(element.GetInfo());
}

Console.WriteLine($"Objectos Creados: {Beer.QuantityObjects} ");
Console.WriteLine(Operations.Add(5, 6));
Console.WriteLine(Operations.Mul(10, 20));


void Show(Drink drink)
    => Console.WriteLine(drink.GetCategory());

SendSome(erdingerBeer);

void SendSome(ISend some)
{
    Console.WriteLine("hago algo");
    some.Send();
    Console.WriteLine("Hago algo mas");
}

decimal GetTotal(ISalable[] concepts)

{
    decimal total = 0;
    foreach (var concept in concepts)
    {
        total += concept.GetPrice();
    }
    return total;
}

/*
Console.WriteLine(delirium.GetCategory());
Console.WriteLine(erdingerBeer.GetInfo());
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
Console.WriteLine(delirium.GetInfo(5));
Console.WriteLine(erdingerBeer.GetInfo());
*/
