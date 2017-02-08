using System;
using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;
    private static List<string> _cityList = new List<string>();

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

    public static List<string> GetAll()
    {
      return _cityList;
    }
    public void Save()
    {
      _cityList.Add(_city);
    }

    public static void ClearAll()
    {
      _cityList.Clear();
    }

  }
}
