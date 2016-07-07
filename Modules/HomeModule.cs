using Nancy;
using System.Collections.Generic;
using System;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {

        return View["index.cshtml"];
      };
  

    }
  }
}
