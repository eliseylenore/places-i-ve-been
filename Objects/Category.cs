using System.Collections.Generic;

namespace Places.Objects
{
  public class Category
  {
    private static List<Category> _categoryList = new List<Category> {};
    private string _name;
    private int _id;
    private List<Place> _places;

    public Category(string categoryName)
    {
      _name = categoryName;
      _categoryList.Add(this);
      _id = _categoryList.Count;
      _places = new List<Place>{};
    }

    public string GetName()
    {
      return _name;
    }
    public int GetID()
    {
      return _id;
    }
    public List<Place> GetPlaces()
    {
      return _places;
    }
    public void AddPlace(Place place)
    {
      _places.Add(place);
    }
    public static List<Category> GetAll()
    {
      return _categoryList;
    }
    public static void Clear()
    {
      _categoryList.Clear();
    }
    public static Category Find(int searchId)
    {
      return _categoryList[searchId - 1];
    }
  }
}
