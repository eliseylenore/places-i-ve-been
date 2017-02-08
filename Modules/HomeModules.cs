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

        Get["/allPlaces"] = _ => {
          List<Place> allPlaces = Place.GetAll();
          return View["all_places.cshtml", allPlaces];
        };

        Get["/place/new"] = _ => {
          return View["place_form.cshtml"];
        };

        Post["/allPlaces"] = _ => {
          Place newPlace = new Place(Request.Form["new-city"]);
          List<Place> allPlaces = Place.GetAll();
          return View["all_places.cshtml", allPlaces];
        };

        Get["/allPlaces/{id}"] = parameters => {
          Place place = Place.Find(parameters.id);
          return View["place.cshtml", place];
        };
    }
  }
}
