using System;
using System.Collections.Generic;

namespace Plant.GrowPlant
{
  public class Grow
  {
    public int _age { get; set; }
    public int _size { get; set; }
    public int _health { get; set; }

    public Grow()
    {
      _age = 0;
      _size = 0;
      _health = 10;
    }
    public string Water()
    {
      _size += 1;
      if (_health == 20)
      {
        return "Your plant is already healthy!";
      }
      else
      {
        _health += 1;
        return "You've watered your plant. It looks a little healthier.";
      }
    }
    public string Feed()
    {
      if (_health == 20)
      {
        return "Your plant is fully fed!";
      }
      else
      {
        _health += 2;
        _size += 1;
        return "You fed your plant. It looks a little healthier and a little bigger.";
      }
    }
    public string GiveSunshine()
    {
      if (_health == 20)
      {
        return "Your plant has had enough sunshine!";
      }
      else
      {
        _health += 1;
        _size += 1;
        return "You've moved your plant into the sun. It looks a little healthier and a little bigger.";
      }
    }
    public string AgePlant()
    {
      if (_age == 10)
      {
        return "Your plant has blossomed!";
      }
      else
      {
        _age += 1;
        _health -= 1;
        return "Your plant has grown.";

      }
    }
  }
}