using System;
using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;

    public Place (string city)
    {
      _city = city;
    }

    public void setCity(string cityName)
    {
      _city = cityName;
    }

    public string getCity()
    {
      return _city;
    }
  }
}
