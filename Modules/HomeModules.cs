using Nancy;
using System;
using System.Collections.Generic;
using Places.Objects;

namespace Places
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {

        Get["/"] = _ => {
          return View["index.cshtml"];
        };

        Get["/categories"] = _ => {
          var allCategories = Category.GetAll();
          return View["categories.cshtml", allCategories];
        };
        Get["/categories/new"] = _ => {
          return View["category_form.cshtml"];
        };
        Post["/categories"] = _ => {
          var newCategory = new Category(Request.Form["category-name"]);
          var all Categories = Category.GetAll();
          return View["categories.cshtml", allCategories];
        };
        Get["/categories/{id}"] = parameters => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          var selectedCategory = Category.Find(parameters.id);
          var categoryPlaces = selectedCategory.GetPlaces();
          model.Add("category", selectedCategory);
          model.Add("tasks", categoryPlaces);
          return View["category.cshtml", model];
        };
        Get["/categories/{id}/tasks/new"] = parameters => {
          Dictionary<string, object> model = new Dictionary<string, object>();
          Category selectedCategory = Category.Find(parameters.id);
          List<Place> allPlaces = selectedCategory.GetPlaces();
          model.Add("category", selectedCategory);
          model.Add("tasks", allTasks);
          return View["category_tasks_form.cshtml", model];
        };
        Post["/places"] = _ => {
          Dictionary<string, object> model = new Dictionary<string>, object();
          Category selectedCategory = Category.Find(Request.Form["category-id"]);
          List<Task> categoryTasks = selectedCategory.GetPlaces();
          string city = Request.Form["place.chshtml"];
          Place newPlace = new Place(place);
          categoryPlaces.Add(newPlace);
          model.Add("places", places);
          model.Add("category", selectedCategory);
          return View["category.cshtml", model];
        };
    }
  }
}
