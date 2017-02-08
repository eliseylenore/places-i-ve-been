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
      Get["/all_places"] = _ => {
        List<string> cityNames = Place.GetAll();
        View["all_places.cshtml", cityNames];
      };
        Get["/"] = _ => View["index.cshtml"];
        Post["/place_created"] = _ => {
          Place newPlace = new Place(Request.Form["new-city"]);
          newPlace.Save();
          return View["place_created.cshtml", newPlace];
        };

    }
  }
}
