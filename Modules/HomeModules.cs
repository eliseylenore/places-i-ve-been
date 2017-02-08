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
    }
  }
}
