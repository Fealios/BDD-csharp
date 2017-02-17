using Xunit;
using System.Collections.Generic;

namespace BDD.Objects
{
    public class SearchTest
    {
        [Fact]
        public void GetSearchedString_ReturnsSameString_true()
        {
            Search testSearch = new Search("word", "more");
            Assert.Equal("word", testSearch.GetSearchedString());
        }
    }
}
