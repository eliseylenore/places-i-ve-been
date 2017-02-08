using System;
using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;
    private static List<Place> _cityList = new List<Place>();
    private int _id;

    public Place (string city)
    {
      _city = city;
      _cityList.Add(this);
      _id = _cityList.Count;
    }

    public void SetCity(string cityName)
    {
      _city = cityName;
    }

    public string GetCity()
    {
      return _city;
    }

    public static List<Place> GetAll()
    {
      return _cityList;
    }
    public static void ClearAll()
    {
      _cityList.Clear();
    }
    public int GetId()
    {
      return _id;
    }
    public static Place Find(int searchId)
    {
      return _cityList[searchId-1];
    }

  }
}
