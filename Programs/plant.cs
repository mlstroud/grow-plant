using System;
using System.Collections.Generic;

namespace Plant.Program
{
  public class Grow
  {
    private int _age;
    private int _size;
    private int _health;

    public Plant()
    {
      _age = 0;
      _size = 0;
      _health = 10;
    }
    public string Water()
    {
      _size += 1;
      if (_health == 15)
      {
        return "Your plant is already healthy!";
      }
      else
      {
        _health += 1;
      }
    }
    public string Feed()
    {
      if (_health == 15)
      {
        return "Your plant is fully fed!";
      }
      else
      {
        _health += 1;
        _size += 1;
      }
    }
    public string GiveSunshine()
    {
      if (_health == 15)
      {
        return "Your plant has had enough sunshine!";
      }
      else
      {
        _health += 1;
        _size += 1;
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

      }
    }
  }
}