using System;
using System.Collections.Generic;
using Plant.GrowPlant;

namespace Plant
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to grow a plant? (Yes/No)");
      string userInput = (Console.ReadLine()).ToLower();
      string plantStatus = "";

      if (userInput == "yes")
      {
        Grow plant = new Grow();
        while (plant._age < 20 && plant._health > 0)
        {
          Console.WriteLine("What would you like to give your plant? (Water/Food/Sunlight)");
          userInput = (Console.ReadLine()).ToLower();

          if (userInput == "water")
          {
            plantStatus = plant.Water();
          }
          else if (userInput == "food")
          {
            plantStatus = plant.Feed();
          }
          else if (userInput == "sunlight")
          {
            plantStatus = plant.GiveSunshine();
          }
          else
          {
            plantStatus = "Sorry, that was not an option.";
          }

          plant.AgePlant();
          Console.WriteLine(plantStatus);
        }
      }
      else
      {
        Console.WriteLine("Goodbye.");
      }
    }
  }
}