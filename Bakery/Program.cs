using System;
using Bakery;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("We sell fresh bread, and tasy pastries");
    Console.WriteLine("Bread prices are 1 for $5, 2 for $10, and the third one is on us!");
    Console.WriteLine("Pastry prices are 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10");
    Console.WriteLine("How many loaves of bread would you like");
    int bread = int.Parse(Console.ReadLine());
    Bread newBread = new Bread(bread);
    newBread.SetPrice();
    int breadPrice = newBread.Price;
    Console.WriteLine("total bread cost:$" + breadPrice);
    Console.WriteLine("How many pastries would you like?");
    int pastries = int.Parse(Console.ReadLine());
    Pastry newPastry = new Pastry(pastries);
    newPastry.SetPrice();
    int pastryPrice = newPastry.Price;
    Console.WriteLine("total pastry cost $" + pastryPrice);
    int total = pastryPrice + breadPrice;
    Console.WriteLine("the total on your order is $" + total);
    Console.WriteLine("Would you like to place a new order? Type Y for yes, or anything else for no");
    string response = Console.ReadLine();
    if (response == "Y")
    {
      Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
      Main();
    }
  }
}