using Software2KnowledgeCheck1;

var newYork = new City();
var empireStateBuilding = new CreateBuilding<HighRise> { Name = "Empire State Building" };
var oneWorldTradeCenter = new CreateBuilding<HighRise> { Name = "One World Trade Center" };
var parkPlaceTower = new CreateBuilding<Apartment> { Name = "Park Place Tower" };
var marvingGardensBuilding = new CreateBuilding<Apartment> { Name = "Marvin Gardens Building" };

var newYorkBuildings = newYork.Buildings;

newYorkBuildings.Add(empireStateBuilding);
newYorkBuildings.Add(oneWorldTradeCenter);
newYorkBuildings.Add(parkPlaceTower);
newYorkBuildings.Add(marvingGardensBuilding);

Console.WriteLine("New York City has some of the world's most famous buildings!");
Console.WriteLine("Some of those buildings you can visit are:");
Console.WriteLine("-------------------------------------------------------");

foreach (var building in newYorkBuildings)
{
    Console.WriteLine(building.Name);
}

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Enjoy your stay in New York City!!!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();