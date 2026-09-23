Console.WriteLine("=== Part 1: Road Trip ===");

Console.WriteLine(" How many miles in the road trip? ");
double totalMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the price per gallon of gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = totalMiles / milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("c"));

Console.WriteLine("=== Part 2: Pizza Party ===");

Console.Write("How many people are going: ");
int people = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas: ");
int pizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const int slicesPerPizza = 8;

int totalSlices = pizzas * slicesPerPizza;

double slicesPerPerson = (double)totalSlices / people;

double pizzaCost = pizzas * pricePerPizza;

Console.WriteLine();

Console.WriteLine("Total slices: " + totalSlices);
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

Console.WriteLine("=== Part 3: Paycheck ===");

Console.Write("Hours worked this week: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());