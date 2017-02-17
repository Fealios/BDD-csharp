using Nancy;
using System.Collections.Generic;
using BDD.Objects;

namespace BDD
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };
        }
    }
}
