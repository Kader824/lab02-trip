/*
 *Name:        Kade Russell
 *Course:      CSCI 1250, Section 001
 *Assignment:  Lab 02, Trip Calculator
 *Date:        September 22, 2026
 *Description: Calculates the fuel, food, and work hours behind one road trip.
*/

// Part 1 calculates the fuel cost for the road trip.
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

// Part 2 calculates the pizza cost and slices per person.
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

// Part 3 calculates gross pay, taxes, and take-home pay.
Console.WriteLine("=== Part 3: Paycheck ===");

Console.Write("Hours worked this week: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("Hourly rate: ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double taxRate = 0.18;

double grossPay = hoursWorked * hourlyRate;

double taxWithheld = grossPay * taxRate;

double takeHomePay = grossPay - taxWithheld;

Console.WriteLine();

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

Console.WriteLine("=== Part 4: The Whole Trip ===");

double tripTotal = fuelCost + pizzaCost; 

double costPerPerson = tripTotal / people;

double takeHomePayPerHour = takeHomePay / hoursWorked;

double hoursNeeded = costPerPerson / takeHomePayPerHour;

Console.WriteLine();

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursNeeded.ToString("F2"));