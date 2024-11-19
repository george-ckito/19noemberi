using _19noemberi;

Car tesla = new Car("Tesla", 250, 10, 100000);
Car bmw = new Car("BMW", 200, 8, 80000);
Car mercedes = new Car("Mercedes", 220, 9, 90000);
Car audi = new Car("Audi", 230, 7, 70000);
Garage garage = new Garage(tesla, bmw, mercedes, audi);
Console.WriteLine(Garage.count);
garage.ShowCars();
Console.WriteLine("-- Fastest:");
garage.GetFastest();
Console.WriteLine("\n-- Most Expensive:");
garage.GetExpensive();
Console.WriteLine("\n-- Cheapest:");
garage.GetCheapest();
Console.WriteLine("\n-- Newest:");
garage.GetNewest();
Console.WriteLine("\n-- Tesla:");
garage.GetTesla();