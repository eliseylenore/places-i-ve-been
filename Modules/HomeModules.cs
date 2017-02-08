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
        Get["/"] = _ => View["index.cshtml"];
        Post["/place_created"] = _ => {
          Place newPlace = new Place(Request.Form["new-city"]);
          return View["place_created.cshtml", newPlace];
        };
    }
  }
}
