
// PizzaParty Calculator 
// Author: Taylor McLaughlin
// Date: 2025/1/21

// define and declare variables for calculator
int numberOfGuests; 
int slicesPerGuest = 3; // assuming each guest wanbts 3 pieces of pizza
int slicesPerPizza = 8; // standard Za has 8 slices

// prompt the user to enter the number of guests
Console.Write("Please enter the number of guests: ");

// call parse function to turn the value the user enters into an int
numberOfGuests = int.Parse(Console.ReadLine());

// Calculate the total number of slices needed:
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

// heavy lifting - number of pizzas required
int pizzasNeeded = /* cast to int */ (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

// String interpolation aka drop variable into string output ($) output number of pizzas needed
Console.WriteLine($"for {numberOfGuests} guests, you will need {totalSlicesNeeded} slices, totaling a total of {pizzasNeeded} pizzas needed.");

