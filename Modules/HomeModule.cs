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

            Post["/newsearch"] = _ =>
            {
                Search newSearch = new Search(Request.Form["tobesearched"],Request.Form["searchitem"]);
                return View["search-page.cshtml", newSearch];
            };
        }
    }
}
