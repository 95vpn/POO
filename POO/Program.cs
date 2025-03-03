using POO.Bussines;

Beer erdingerBeer = new Beer("Erdinger", 3, -2, 1000);

var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024,12,01), 330);

//Drink drink = new Beer("Erdinger", 3, -2, 1000);

Drink drink = new Wine(500);
Show(drink);
drink = new Beer("Corona", 2, 4, 330);
Show(drink);
Show(erdingerBeer);

void Show(Drink drink)
    => Console.WriteLine(drink.GetCategory());


/*
Console.WriteLine(delirium.GetCategory());
Console.WriteLine(erdingerBeer.GetInfo());
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
Console.WriteLine(delirium.GetInfo(5));
Console.WriteLine(erdingerBeer.GetInfo());
*/
